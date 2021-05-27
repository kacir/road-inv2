using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RoadInv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace roadInvUnitTest
{
    public class ValidationLogicUnitTest
    {
        public RoadInv.DB.roadinvContext _dbContext;
        public RoadInv.Models.ValidationModel validation;
        private readonly ITestOutputHelper logger;

        public ValidationLogicUnitTest(ITestOutputHelper logger)
        {
            var config = InitConfiguration();
            var connectionString = config["EntityConnectinString"];

            var serviceCollection = new ServiceCollection();
            serviceCollection
            .AddDbContext<RoadInv.DB.roadinvContext>(options => options.UseSqlServer(connectionString),
                ServiceLifetime.Transient);

            var conContextOptions = new DbContextOptionsBuilder<RoadInv.DB.roadinvContext>();
            conContextOptions.UseSqlServer(connectionString);


            _dbContext = new RoadInv.DB.roadinvContext(options: conContextOptions.Options);

            validation = new RoadInv.Models.ValidationModel(_dbContext);

            this.logger = logger;
        }

        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.test.json")
                .Build();
            return config;
        }

        private static List<string> AffectedFields(List<RoadInv.Models.ErrorItemModel> rawList)
        {
            var resultList = new List<string>();
            foreach (var error in rawList)
            {
                foreach(var field in error.Fields)
                {
                    resultList.Add(field);
                }
            }

            //remove duplicates
            resultList = resultList.Distinct().ToList();

            return resultList;
        }

        private static string AffectedFieldsMessage(List<string> rawList)
        {
            var builderString = "";
            foreach(var st in rawList)
            {
                builderString = builderString + "," + st;
            }
            return builderString;
        }

        [Fact]
        public void EmptyInput(){
            var segment = new RoadInv.DB.RoadInv();
            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);


            Assert.True(results.Count > 0, "Error was not raised at blank new record");
            logger.WriteLine("error list length was " + results.Count.ToString() );
            //functional class should not be logged in this senario
            var errorFields = AffectedFields(results);

            Assert.Contains(FieldsListModel.AH_County, errorFields);
            Assert.Contains(FieldsListModel.AH_Route, errorFields);
            Assert.Contains(FieldsListModel.AH_Section, errorFields);
            Assert.Contains(FieldsListModel.LOG_DIRECT, errorFields);
            Assert.Contains(FieldsListModel.AH_BLM, errorFields);
            Assert.Contains(FieldsListModel.AH_ELM, errorFields);

            Assert.Equal(6, errorFields.Count);
            logger.WriteLine("fields flagg in this operation are the following " + AffectedFieldsMessage(errorFields));
        }

        [Theory]
        [InlineData("2", "ARNOLDDRIVE1", "123", "A", 0, 0.2)]
        public void MinAttributes(string county, string route, string section, string direction, decimal BLM, decimal ELM)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = county;
            segment.AhRoute = route;
            segment.AhSection = section;
            segment.LogDirect = direction;
            segment.AhBlm = BLM;
            segment.AhElm = ELM;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            Assert.True(results.Count == 0, "Mimimalist record is is causeing errors when it should not");
            var errorFields = AffectedFields(results);
            logger.WriteLine("fields flagg in this operation are the following " + AffectedFieldsMessage(errorFields));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(0.4545)]
        [InlineData(0.77)]
        [InlineData(0.3)]
        [InlineData(343)]
        [InlineData(34)]
        [InlineData(10)]
        [InlineData(10.465)]
        [InlineData(8.398)]
        public void logmilesEqual(decimal logmile)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "2";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "123";
            segment.LogDirect = "A";
            segment.AhBlm = logmile;
            segment.AhElm = logmile;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            Assert.True(results.Count == 1, "BLM and ELM are equal to each other");
            var errorFields = AffectedFields(results);
            Assert.Contains(FieldsListModel.AH_BLM, errorFields);
            Assert.Contains(FieldsListModel.AH_ELM, errorFields);
            Assert.True(errorFields.Count == 2, "Extra errors around BLM and ELM equaling each other");

            logger.WriteLine("fields flagg in this operation are the following " + AffectedFieldsMessage(errorFields));
        }

        //logmile negitive
        [Theory]
        [InlineData(0.2, 0.4, true)]
        [InlineData(-1, 0.4, false)]
        [InlineData(-5, -2, false)]
        [InlineData(-900, -50, false)]
        public void logmileNegitive(decimal blm, decimal elm, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "2";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "123";
            segment.LogDirect = "A";
            segment.AhBlm = blm;
            segment.AhElm = elm;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0, AffectedFieldsMessage(errorFields));
            } else
            {
                Assert.True(results.Count == 1);
            }
            
        }

        [Theory]
        [InlineData(5, 12, 0)]
        [InlineData(5, 999, 0)]
        [InlineData(5, 99999, 1)]
        [InlineData(500, 99999, 1)]
        [InlineData(900, 999, 0)]
        [InlineData(1001, 1002, 2)]
        [InlineData(1001, 100000000, 2)]
        [InlineData(0, 9999999999, 1)]
        //logmile greater than 999.999
        public void LogmileMassive(decimal blm, decimal elm, int erroCount)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "2";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "123";
            segment.LogDirect = "A";
            segment.AhBlm = blm;
            segment.AhElm = elm;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            Assert.True(results.Count == erroCount, AffectedFieldsMessage(errorFields));
 
        }



        [Theory]
        [InlineData(5 , 0)]
        public void LogmileFlipped(decimal blm, decimal elm)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "2";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "123";
            segment.LogDirect = "A";
            segment.AhBlm = blm;
            segment.AhElm = elm;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            Assert.True(results.Count == 1, "BLM and ELM are equal to each other");
            var errorFields = AffectedFields(results);
            logger.WriteLine("fields flagg in this operation are the following " + AffectedFieldsMessage(errorFields));
        }

        
        [Theory]
        [InlineData("ARNOLDDRIVE1", true)]
        [InlineData("ARNOLDDR", true)]
        [InlineData("MAINSTREET", true)]
        [InlineData("452", true)]
        [InlineData("42STREET", true)]
        [InlineData("JEFFERSONDRIVE", true)]
        [InlineData("OLDHIGHWAY12", true)]
        [InlineData("XMASTRAIL", true)]
        [InlineData("140", true)]
        [InlineData("100", true)]
        [InlineData("107", true)]
        [InlineData("XXX", true)]
        [InlineData("100BIZ", true)]
        [InlineData("~CIRCLE", false)]
        [InlineData("*TRAIL", false)]
        [InlineData("$$DRIVE", false)]
        [InlineData("^34STREET", false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        public void ValidRouteChar(string route, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "2";
            segment.AhRoute = route;
            segment.AhSection = "123";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0, "This combination should not cause an error");
            } else
            {
                Assert.True(results.Count == 1, "error number does not match. Should have one error");
                Assert.Contains(FieldsListModel.AH_Route, errorFields);
            }
            logger.WriteLine("fields flagg in this operation are the following " + AffectedFieldsMessage(errorFields));
        }

        [Theory]
        [InlineData("fsfdsfsdfdsfdsfs", true)]
        [InlineData("fsfdsfsdfdsfdsfs54645", true)]
        [InlineData("fdsfd453645654654STREETOFHEVENfdsfd453645654654STREETOFHEVEN", true)]
        [InlineData("fdsfd453645654654STREETOFHEVENfdsfd453645654654STREETOFHEVENgfdgdgfdgdgfdgd", true)]
        [InlineData("fdsfd453645654654STREETOFHEVENfdsfd453645654654STREETOFHEVENgfdgdgfdgdgfdgd56464654", true)]
        [InlineData("fdsfd453645654654STREETOFHEVENfdsfd453645654654STREETOFHEVENgfdgdgfdgdgfdgd56464654gfhgfafdsfds", true)]
        [InlineData("fdsfd453645654654STREETOFHEVENfdsfd453645654654STREETOFHEVENgfdgdgfdgdgfdgd56464654gfhgfafdsfds4523", true)]
        [InlineData("fdsfd453645654654STREETOFHEVENfdsfd453645654654STREETOFHEVENgfdgdgfdgdgfdgd56464654gfhgfafdsfds452354354345", false)]
        public void ValidRouteLong(string route, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "2";
            segment.AhRoute = route;
            segment.AhSection = "123";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.AH_Route, errorFields);
            }

        }


        //invalid section characters
        [Theory]
        [InlineData("123", true)]
        [InlineData("12B", true)]
        [InlineData("1B", true)]
        [InlineData("zzz", true)]
        [InlineData("45", true)]
        [InlineData("107", true)]
        [InlineData("1", true)]
        [InlineData("0", true)]
        [InlineData("100", true)]
        [InlineData("150", true)]
        [InlineData("555", true)]
        [InlineData("999", true)]
        [InlineData("10B", true)]
        [InlineData("#23", false)]
        [InlineData("6%", false)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData("  ", false)]
        [InlineData("   ", false)]
        public void ValidSectionChar(string section, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "2";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = section;
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0, "This combination should not cause an error");
            } else
            {
                Assert.True(results.Count == 1, "there should be a single error for the invalid character");
                Assert.Contains(FieldsListModel.AH_Section, errorFields);
            }
            logger.WriteLine("fields flagg in this operation are the following " + AffectedFieldsMessage(errorFields));
        }

        [Theory]
        [InlineData("1", true)]
        [InlineData("AA", true)]
        [InlineData("107", true)]
        [InlineData("1074", false)]
        [InlineData("xxxxxxxxxx", false)]
        [InlineData("ZZZZZZZ", false)]
        [InlineData("000000000", false)]
        public void ValidSectionLength(string section, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "2";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = section;
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.AH_Section, errorFields);
            }
        }


        [Theory]
        [InlineData("1", "1", true)]
        [InlineData("2", "1", true)]
        [InlineData("3", "1", true)]
        [InlineData("5", "60", true)]//federal agency
        [InlineData("4", "64", true)]//forest service
        [InlineData("5", "4", true)]//forest service
        [InlineData("1", "60", false)]//federal agency
        [InlineData("2", "64", false)]//forest service
        [InlineData("2", "4", false)]//forest service
        public void RouteSignGovermentCodePair(string RouteSign, string GovermentCode, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "2";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "123";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;
            segment.RouteSign = RouteSign;
            segment.GovermentCode = GovermentCode;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);
            

            if (expected)
            {
                Assert.True(results.Count == 0, AffectedFieldsMessage(errorFields));
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.GovermentCode, errorFields);
                Assert.Contains(FieldsListModel.RouteSign, errorFields);
            }
            logger.WriteLine("fields flagg in this operation are the following " + AffectedFieldsMessage(errorFields));

        }

        [Theory]
        [InlineData("50392", "1", false)]
        [InlineData("50392", "2", false)]
        [InlineData("50392", "3", true)]
        [InlineData("50392", "4", true)]
        public void UrbanAreaRuralPair(string UrbanAreaCode, string RuralUrbanArea, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "123";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;
            segment.UrbanAreaCode = UrbanAreaCode;
            segment.RuralUrbanArea = RuralUrbanArea;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1, AffectedFieldsMessage(errorFields));
                Assert.Contains(FieldsListModel.UrbanAreaCode, errorFields);
                Assert.Contains(FieldsListModel.RuralUrbanArea, errorFields);
                Assert.True(errorFields.Count == 2);
            }
        }

        [Theory]
        [InlineData("3", false)]
        [InlineData("4", false)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        //null urbanAreaCode
        public void UrbanAreaCodeZero(string ruralUrbanArea, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "123";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;
            segment.UrbanAreaCode = "00000";
            segment.RuralUrbanArea = ruralUrbanArea;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.UrbanAreaCode, errorFields);
                Assert.Contains(FieldsListModel.RuralUrbanArea, errorFields);
                Assert.True(errorFields.Count == 2);
            }
        }



        [Theory]
        [InlineData("1", "1", true)]
        [InlineData("2", "1", false)]
        [InlineData("3", "1", false)]
        [InlineData("4", "1", false)]
        [InlineData("5", "1", false)]
        [InlineData("6", "1", false)]
        [InlineData("7", "1", false)]
        [InlineData("1", "2", false)]
        [InlineData("1", "3", false)]
        [InlineData("1", "4", false)]
        [InlineData("1", "5", false)]
        public void FuncClassRouteSignPair(string funcClass, string routeSign, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "123";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;
            segment.FuncClass = funcClass;
            segment.RouteSign = routeSign;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);
            var errormessage = ValidationLogicUnitTest.AffectedFieldsMessage(errorFields);

            if (expected)
            {
                Assert.True(results.Count == 0, errormessage);
            } else
            {
                Assert.True(results.Count == 1, errormessage);
                Assert.Contains(FieldsListModel.FuncClass, errorFields);
                Assert.Contains(FieldsListModel.RouteSign, errorFields);
                Assert.True(errorFields.Count == 2, errormessage);
            }

        }


        //I do not understand this validation. I think it is supposed to mean all functional class 2 routes are multilane divided roads
        [Theory]
        [InlineData("2", "4", true)]
        [InlineData("2", "1", false)]
        [InlineData("2", "2", false)]
        [InlineData("2", "3", false)]
        public void FuncClassTypeOperationPair(string funcClass, string TypeOperation, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "123";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;
            segment.FuncClass = funcClass;
            segment.TypeOperation = TypeOperation;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);
            var errormessage = ValidationLogicUnitTest.AffectedFieldsMessage(errorFields);

            if (expected)
            {
                Assert.True(results.Count == 0, errormessage);
            } else
            {
                Assert.True(results.Count == 1, errormessage);
                Assert.Contains(FieldsListModel.FuncClass, errorFields);
                Assert.Contains(FieldsListModel.TypeOperation, errorFields);
                Assert.True(errorFields.Count == 2, errormessage);
            }

        }


        //APHN Functional Class Pair
        [Theory]
        [InlineData("1", "1", true)]
        [InlineData("7", "0", true)]
        public void funcClassAPHNPair(string funcClass, string APHN, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "123";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;
            segment.FuncClass = funcClass;
            segment.Aphn = APHN;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.FuncClass, errorFields);
                Assert.Contains(FieldsListModel.APHN, errorFields);
                Assert.True(errorFields.Count == 2);
            }
        }

        [Theory]
        [InlineData("0", true)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        [InlineData("6", true)]
        [InlineData("60", false)]
        [InlineData("a", false)]
        [InlineData("fg", false)]
        [InlineData("22", false)]
        public void LeftShoulderValid(string leftShoulderSurface, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "123";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;
            segment.LeftShoulderSurface = leftShoulderSurface;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.LeftShoulderSurface, errorFields);
                Assert.True(errorFields.Count == 1);
                Assert.Contains(FieldsListModel.LeftShoulderSurface, errorFields);
            }
        }

        [Theory]
        [InlineData("0", true)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        [InlineData("6", true)]
        [InlineData("60", false)]
        [InlineData("a", false)]
        [InlineData("fg", false)]
        [InlineData("22", false)]
        public void RightShoulderValid(string rightShoulderSurface, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "123";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;
            segment.RightShoulderSurface = rightShoulderSurface;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            }
            else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.RightShoulderSurface, errorFields);
                Assert.True(errorFields.Count == 1);
                Assert.Contains(FieldsListModel.RightShoulderSurface, errorFields);
            }
        }

        [Theory]
        [InlineData("0", true)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        [InlineData("6", true)]
        [InlineData("7", true)]
        [InlineData("8", true)]
        [InlineData("9", true)]
        [InlineData("10", true)]
        [InlineData("11", false)]
        [InlineData("12", false)]
        [InlineData("555", false)]
        public void validNHS(string nhs, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "123";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.Nhs = nhs;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count > 0);
                Assert.Contains(FieldsListModel.NHS, errorFields);
                Assert.True(errorFields.Count == 1);
            }
        }

        //exception case about SectionCode x as one-way couplet
        [Theory]
        [InlineData("B", true)]
        [InlineData("A", false)]
        public void OnewayCoupletDirection(string direction, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12X";
            segment.LogDirect = direction;
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.LOG_DIRECT, errorFields);
                Assert.Contains(FieldsListModel.AH_Section, errorFields);
                Assert.True(errorFields.Count == 2);
            }
        }

        //One way couplet TypeOperation
        [Theory]
        [InlineData("3", true)]
        public void OneWayCoupletTypeOperation(string TypeOperation, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12X";
            segment.LogDirect = "B";
            segment.TypeOperation = TypeOperation;
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.False(results.Count == 1);
                Assert.Contains(FieldsListModel.TypeOperation, errorFields);
                Assert.Contains(FieldsListModel.AH_Section, errorFields);
                Assert.True(errorFields.Count == 2);
            }
        }


        //NHS Functional Class Pair
        //page24
    }
}
