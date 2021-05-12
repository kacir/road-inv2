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

namespace roadInvUnitTest
{
    public class ValidationComplexUnitTest
    {
        public RoadInv.DB.roadinvContext _dbContext;
        public RoadInv.Models.ValidationModel validation;


        public ValidationComplexUnitTest()
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
                foreach (var field in error.Fields)
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
            foreach (var st in rawList)
            {
                builderString = builderString + "," + st;
            }
            return builderString;
        }

        /*If Route = 1 and Type Road = 1 Then NHS must be 1 and APHN = 1*/
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", false)]
        [InlineData("3", false)]
        [InlineData("4", false)]
        public void RulePG43A1(string NHS, bool expected )
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;
            segment.TypeRoad = "1";
            segment.Nhs = NHS;
            segment.RouteSign = "1";

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);
            ;

            if (expected)
            {
                Assert.True(errorFields.Count == 0,  AffectedFieldsMessage(errorFields));
            } else
            {
                Assert.True(errorFields.Count == 2, results.Count.ToString() + ": " +  AffectedFieldsMessage(errorFields));
                Assert.Contains(FieldsListModel.NHS, errorFields);
                Assert.Contains(FieldsListModel.RouteSign, errorFields);
            }
        }

        /*If Route = 1 and Type Road = 1 Then NHS must be 1 and APHN = 1*/
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", false)]
        [InlineData("3", false)]
        [InlineData("4", false)]
        public void RulePG43A2(string APHN, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.TypeRoad = "1";
            segment.Aphn = APHN;
            segment.RouteSign = "1";

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(errorFields.Count == 0, AffectedFieldsMessage(errorFields));
            }
            else
            {
                Assert.True(errorFields.Count == 2, AffectedFieldsMessage(errorFields));
                Assert.Contains(FieldsListModel.APHN, errorFields);
                Assert.Contains(FieldsListModel.RouteSign, errorFields);
            }
        }


        /*If RouteSign = 2 or 3 and TypeRoad = 1 if NHS <> 0 then APHN = 1*/
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", false)]
        [InlineData("3", false)]
        [InlineData("4", false)]
        public void RulePG34B(string APHN, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.RouteSign = "2";
            segment.TypeRoad = "1";
            segment.Nhs = "1";
            segment.Aphn = APHN;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(errorFields.Count == 0, AffectedFieldsMessage(errorFields));
            } else
            {
                Assert.True(errorFields.Count == 4, AffectedFieldsMessage(errorFields));
                Assert.Contains(FieldsListModel.APHN, errorFields);
                Assert.Contains(FieldsListModel.RouteSign, errorFields);
                Assert.Contains(FieldsListModel.TypeRoad, errorFields);
                Assert.Contains(FieldsListModel.NHS, errorFields);
            }

        }

        /* If NHS = 0 the APHN <> 1 */
        [Theory]
        [InlineData("1", false)]
        public void RuleGP34C(string APHN, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.Aphn = APHN;
            segment.Nhs = "0";
        }

        /* If specialSystem = 9 then NHS must be 1 */
        [Theory]
        [InlineData("5", "1", true)]
        [InlineData("1", "1", true)]
        [InlineData("9", "1", true)]
        [InlineData("9", "2", false)]
        [InlineData("9", "3", false)]
        [InlineData("9", "4", false)]
        [InlineData("9", "5", false)]
        [InlineData("9", "6", false)]
        [InlineData("9", "7", false)]
        [InlineData("9", "8", false)]
        [InlineData("9", "9", false)]
        [InlineData("9", "10", false)]
        public void StrahnetOnNHS(string specialSystem, string NHS, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.Nhs = NHS;
            segment.SpecialSystems = specialSystem;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0, ValidationComplexUnitTest.AffectedFieldsMessage(errorFields));
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.SpecialSystems, errorFields);
                Assert.Contains(FieldsListModel.NHS, errorFields);
            }
        }

        //Both Direction # lanes

        //page 39
        [Fact]
        public void InvalidSingleLaneDividedHighway()
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.TypeOperation = "4";
            segment.BothDirectionNumLanes = "1";

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            Assert.True(results.Count == 1);
            Assert.Contains(FieldsListModel.BothDirectionNumLanes, errorFields);
            Assert.Contains(FieldsListModel.TypeOperation, errorFields);
        }

        [Theory]
        [InlineData("1")]
        [InlineData("2")]
        [InlineData("3")]
        public void ValidNotSingleLaneDividedHighway(string TypeOperation)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.BothDirectionNumLanes = "1";
            segment.TypeOperation = TypeOperation;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            Assert.True(results.Count == 0);

        }

        [Theory]
        [InlineData("2", "1", true)]
        [InlineData("5", "1", true)]
        [InlineData("8", "1", true)]
        [InlineData("3", "1", true)]
        [InlineData("4", "1", true)]
        [InlineData("4", "4", false)]
        [InlineData("2", "4", false)]
        [InlineData("1", "4", false)]
        public void DividedHighwayLanes(string BothDirectionNumLanes, string OneDirectionNumLanes, bool Expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.TypeOperation = "4";
            segment.BothDirectionNumLanes = BothDirectionNumLanes;
            segment.OneDirectionNumLanes = OneDirectionNumLanes;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);


        }

        [Theory]
        [InlineData("2", "2", true)]
        [InlineData("8", "8", true)]
        [InlineData("5", "5", true)]
        [InlineData("10", "10", true)]
        [InlineData("10", "5", true)]
        [InlineData("10", "1", true)]
        [InlineData("5", "1", true)]
        [InlineData("3", "2", true)]
        [InlineData("3", "7", false)]
        [InlineData("3", "4", false)]
        public void BothDirectionsLessThanOrEqualToOneDirection(string BothDirectionNumLanes, string OneDirectionNumLanes, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.BothDirectionNumLanes = BothDirectionNumLanes;
            segment.OneDirectionNumLanes = OneDirectionNumLanes;

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
                Assert.Contains(FieldsListModel.BothDirectionNumLanes, errorFields);
                Assert.Contains(FieldsListModel.OneDirectionNumLanes, errorFields);
            }

        }

        //page 39 BothDirectionNum Lanes last rule

        [Theory]
        [InlineData("1", false)]
        [InlineData("2", false)]
        [InlineData("3", false)]
        [InlineData("4", true)]
        public void BothDirectionGreaterThanOneDirection_TypeOperation(string TypeOperation, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.OneDirectionNumLanes = "1";
            segment.BothDirectionNumLanes = "2";
            segment.TypeOperation = TypeOperation;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.TypeOperation, errorFields);
                Assert.Contains(FieldsListModel.BothDirectionNumLanes, errorFields);
                Assert.Contains(FieldsListModel.OneDirectionNumLanes, errorFields);
            }
        }

        [Theory]
        [InlineData("0", false)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        public void BothDirectionGreaterThanOneDirection_MedianType(string MedianType, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.MedianType = MedianType;
            segment.OneDirectionNumLanes = "1";
            segment.BothDirectionNumLanes = "2";

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.MedianType, errorFields);
                Assert.Contains(FieldsListModel.OneDirectionNumLanes, errorFields);
                Assert.Contains(FieldsListModel.BothDirectionNumLanes, errorFields);
            }
        }

        [Theory]
        [InlineData("0", false)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("5", true)]
        [InlineData("6", true)]
        [InlineData("12", true)]
        public void BothDirectionGreaterThanOneDirection_MedianWidth(string medianWidth, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.MedianWidth = medianWidth;
            segment.OneDirectionNumLanes = "1";
            segment.BothDirectionNumLanes = "2";

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.MedianWidth, errorFields);
                Assert.Contains(FieldsListModel.BothDirectionNumLanes, errorFields);
                Assert.Contains(FieldsListModel.OneDirectionNumLanes, errorFields);
            }
        }

        [Theory]
        [InlineData("0", false)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        [InlineData("6", true)]
        [InlineData("7", true)]
        [InlineData("8", true)]
        [InlineData("9", true)]
        //Page 46 - APHN validations
        public void APHNOneNHS(string NHS, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.Aphn = "1";
            segment.Nhs = NHS;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else 
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.NHS, errorFields);
                Assert.Contains(FieldsListModel.APHN, errorFields);
            }
        
        }
        
        [Theory]
        [InlineData("0" ,true)]
        [InlineData("1", false)]
        [InlineData("2", false)]
        [InlineData("3", false)]
        [InlineData("4", false)]
        [InlineData("5", false)]
        [InlineData("6", false)]
        public void APHN2_NHS_MustBeZero(string NHS, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.Aphn = "2";
            segment.Nhs = NHS;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0, AffectedFieldsMessage(errorFields) + " Count is " + results.Count.ToString());
            } else
            {
                Assert.True(results.Count == 1, AffectedFieldsMessage(errorFields) + " Count is " + results.Count.ToString());
            }
        }


        [Theory]
        [InlineData("1", false)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", false)]
        [InlineData("6", false)]
        [InlineData("7", false)]
        public void APHN2_FuncClass(string funcClass, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.FuncClass = funcClass;
            segment.Aphn = "2";

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0, AffectedFieldsMessage(errorFields) + " Count is " );
            } else
            {
                Assert.True(results.Count == 1, AffectedFieldsMessage(errorFields) + " Count is " );
                Assert.Contains(FieldsListModel.FuncClass, errorFields);
                Assert.Contains(FieldsListModel.APHN, errorFields);
            }

        }

        //page 48
        [Theory]
        [InlineData("2")]
        [InlineData("3")]
        public void InterstatesHaveFullAccessControl(string accessControl)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.RouteSign = "1";
            segment.Access = accessControl;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            Assert.True(results.Count == 1);
            Assert.Contains(FieldsListModel.Access, errorFields);
            Assert.Contains(FieldsListModel.RouteSign, errorFields);
        }

        [Theory]
        [InlineData("1", false)]
        [InlineData("2", false)]
        [InlineData("3", false)]
        [InlineData("4", true)]
        public void FullControlisDividedHighway(string typeOperation, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.Access = "1";
            segment.TypeOperation = typeOperation;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.Access, errorFields);
                Assert.Contains(FieldsListModel.TypeOperation, errorFields);
                Assert.True(errorFields.Count == 2);
            }
        }

        [Theory]
        [InlineData("0", true)]
        [InlineData("1", false)]
        [InlineData("2", false)]
        [InlineData("3", false)]
        [InlineData("4", false)]
        [InlineData("5", false)]
        public void FullControlMedianType(string medianType, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.Access = "3";
            segment.MedianType = medianType;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.Access, errorFields);
                Assert.Contains(FieldsListModel.MedianType, errorFields);
                Assert.True(errorFields.Count == 2);
            }

        }

        [Theory]
        [InlineData("0", false)]
        [InlineData("1", true)]
        [InlineData("5", true)]
        [InlineData("15", true)]
        [InlineData("44", true)]
        [InlineData("86", true)]
        [InlineData("6", true)]
        public void FullControlMedianWidth(string medianWidth, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.MedianWidth = medianWidth;
            segment.Access = "3";

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.Access, errorFields);
                Assert.Contains(FieldsListModel.MedianWidth, errorFields);
                Assert.Equal(2, errorFields.Count);
            }

        }

        //page 49
        [Fact]
        public void InvalidTypeOperationAccessCombo()
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.TypeOperation = "4";
            segment.Access = "3";

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            Assert.True(results.Count == 1);
            Assert.Contains(FieldsListModel.Access, errorFields);
            Assert.Contains(FieldsListModel.TypeOperation, errorFields);
        }

        [Fact]
        public void DividedHighwayWithNoMedianWidth() 
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.TypeOperation = "4";
            segment.MedianWidth = "0";

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            Assert.True(results.Count == 1);
            Assert.Contains(FieldsListModel.TypeOperation, errorFields);
            Assert.Contains(FieldsListModel.MedianWidth, errorFields);
            Assert.True(errorFields.Count == 2);
        }

        [Fact]
        public void DividedHighwayWithNoMedianType()
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.TypeOperation = "4";
            segment.MedianType = "0";

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            Assert.True(results.Count == 1);
            Assert.Contains(FieldsListModel.TypeOperation, errorFields);
            Assert.Contains(FieldsListModel.MedianType, errorFields);
            Assert.True(errorFields.Count == 2);
        }

        //page 52
        [Theory]
        [InlineData("1", false)]
        [InlineData("2", false)]
        [InlineData("3", false)]
        [InlineData("4", true)]
        public void MedianWidthZeroMustHaveTypeOperation4(string typeOperation, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.TypeOperation = typeOperation;
            segment.MedianWidth = "5";

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.TypeOperation, errorFields);
                Assert.Contains(FieldsListModel.MedianWidth, errorFields);
            }
        }

        [Theory]
        [InlineData("0", false)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        public void MedianWidthMedianTypeCombo(string medianType, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.MedianWidth = "12";
            segment.MedianType = medianType;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0, AffectedFieldsMessage(errorFields));
            } else
            {
                Assert.True(results.Count == 1, AffectedFieldsMessage(errorFields));
                Assert.Contains(FieldsListModel.MedianType, errorFields);
                Assert.Contains(FieldsListModel.MedianWidth, errorFields);
            }

        }

        //page 54
        [Theory]
        [InlineData(1, true)]
        [InlineData(5, true)]
        [InlineData(10, true)]
        [InlineData(11, true)]
        [InlineData(12, true)]
        [InlineData(6, true)]
        [InlineData(7, true)]
        [InlineData(8, true)]
        [InlineData(15, false)]
        [InlineData(17, false)]
        [InlineData(19, false)]
        [InlineData(22, false)]
        [InlineData(45, false)]
        [InlineData(150, false)]
        public void LaneWidthMax(int laneWidth, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.LaneWidth = laneWidth;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0, AffectedFieldsMessage(errorFields));
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.LaneWidth, errorFields);
                Assert.Single(errorFields);
            }
        }

        [Theory]
        [InlineData(1, 15, true)]
        [InlineData(4, 15, true)]
        [InlineData(6, 15, true)]
        [InlineData(8, 15, true)]
        [InlineData(10, 15, true)]
        [InlineData(12, 15, true)]
        [InlineData(13, 15, true)]
        [InlineData(2, 15, true)]
        [InlineData(14, 14, true)]
        [InlineData(12, 1, false)]
        [InlineData(14, 13, false)]
        [InlineData(14, 3, false)]
        [InlineData(10, 5, false)]
        [InlineData(6, 3, false)]
        [InlineData(12, 10, false)]
        [InlineData(6, 2, false)]
        public void LaneWidthLessThanOrEqualToSurfaceWidth(int laneWidth, int surfaceWidth, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.LaneWidth = laneWidth;
            segment.SurfaceWidth = surfaceWidth;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.LaneWidth, errorFields);
                Assert.Contains(FieldsListModel.SurfaceWidth, errorFields);
                Assert.True(errorFields.Count == 2);
            }
        }

        [Theory]
        [InlineData(2, 4, "1", true)]
        [InlineData(1, 4, "1", true)]
        [InlineData(4, 8, "1", true)]
        [InlineData(6, 10, "1", true)]
        [InlineData(2, 4, "2", true)]
        [InlineData(3, 10, "2", true)]
        [InlineData(6, 13, "2", true)]
        [InlineData(3, 5, "2", false)]
        [InlineData(6, 10, "2", false)]
        public void SurfacWidthLessThanLaneCombinedLength(int laneWidth, int surfaceWidth, string bothDirectionNumLanes, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.LaneWidth = laneWidth;
            segment.SurfaceWidth = surfaceWidth;
            segment.BothDirectionNumLanes = bothDirectionNumLanes;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.LaneWidth, errorFields);
                Assert.Contains(FieldsListModel.SurfaceWidth, errorFields);
                Assert.Contains(FieldsListModel.BothDirectionNumLanes, errorFields);
                Assert.True(errorFields.Count == 3);
            }

        }

        //page 61
        [Theory]
        [InlineData(10, 10, true)]
        [InlineData(9, 10, true)]
        [InlineData(8, 10, true)]
        [InlineData(2, 10, true)]
        [InlineData(1, 10, true)]
        [InlineData(5, 10, true)]
        [InlineData(4, 10, true)]
        [InlineData(4, 16, true)]
        [InlineData(4, 15, true)]
        [InlineData(40, 41, true)]
        [InlineData(42, 41, false)]
        [InlineData(44, 41, false)]
        [InlineData(44, 40, false)]
        [InlineData(20, 15, false)]
        public void RoadwayWidthLessThanSurfaceWidth(int roadwayWidth, int surfaceWidth, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.RoadwayWidth = roadwayWidth;
            segment.SurfaceWidth = surfaceWidth;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0, AffectedFieldsMessage(errorFields));
            } else
            {
                Assert.True(results.Count == 1, AffectedFieldsMessage(errorFields));
                Assert.Contains(FieldsListModel.RoadwayWidth, errorFields);
                Assert.Contains(FieldsListModel.SurfaceWidth, errorFields);
                Assert.True(errorFields.Count == 2);
            }
        }

        //page 66
        [Theory]
        [InlineData("1", "4" , true)]
        [InlineData("2", "4", true)]
        [InlineData("3", "4", true)]
        [InlineData("4", "4", true)]
        [InlineData("5", "4", true)]
        [InlineData("2", "3", false)]
        [InlineData("2", "2", false)]
        [InlineData("2", "1", false)]
        [InlineData("3", "1", false)]
        [InlineData("4", "1", false)]
        [InlineData("5", "3", false)]
        public void MedianMustHaveTypeOperation4(string medianType, string typeOperation, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.MedianType = medianType;
            segment.TypeOperation = typeOperation;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.MedianType, errorFields);
                Assert.Contains(FieldsListModel.TypeOperation, errorFields);
                Assert.True(errorFields.Count == 2);
            }
        }

        //page 66 last rule
        

    }
}
