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
    /// <summary>
    /// Peforms tests related to proper coded value for different fields. Does not test combinations of values or value logic.
    /// </summary>
    public class ValidationCodesHigherLevelTest
    {
        /// <value> <c>_dbContext</c> - entiy framework context some description of some kind </value>
        public RoadInv.DB.roadinvContext _dbContext;
        /// <value> <c>validation</c> - instance needed in order to perform valdiations against things in the database </value>
        public RoadInv.Models.ValidationModel validation;

        public ValidationCodesHigherLevelTest()
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

        /// <summary>
        /// Loads configuartion setting json file into a confiug object containing the database connection string. 
        /// Method is called during object initialization. Should not be used ouside of this class.
        /// </summary>
        /// <returns>config object containing database connection string</returns>
        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.test.json")
                .Build();
            return config;
        }

        /// <summary>
        /// Turns a list of string objects that are intended to be field names and builts them into a string. 
        /// The intent is this method helps build error messages used in other unit tests. This is only intended as a message helper.
        /// </summary>
        /// <param name="rawList">a string list object containing field names</param>
        /// <returns>a sting version of the inptu rawList object in a comma delinated format</returns>
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

        /// <summary>
        /// Tests various district values against the validation object to see if it assigns errors as expected
        /// </summary>
        /// <param name="district">The ArDOT district number as a string</param>
        /// <param name="expected">a boolean value indicating if errors are going to be returned or not. true for no errors. false for errors</param>
        [Theory]
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
        [InlineData("13", false)]
        [InlineData("14", false)]
        [InlineData("55", false)]
        public void District(string district, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;
            segment.AhDistrict = district;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.DoesNotContain(FieldsListModel.AH_District, errorFields);
            } else
            {
                Assert.Contains(FieldsListModel.AH_District, errorFields);
            }
        }

        /// <summary>
        /// test the county input codes for expected results.
        /// </summary>
        /// <param name="county">The ArDOT County number as a string without padding zeros for one digit numbers</param>
        /// <param name="expected">a boolean value indicating if errors are going to be returned or not. true for no errors. false for errors</param>
        [Theory]
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
        [InlineData("11", true)]
        [InlineData("12", true)]
        [InlineData("13", true)]
        [InlineData("14", true)]
        [InlineData("15", true)]
        [InlineData("16", true)]
        [InlineData("17", true)]
        [InlineData("18", true)]
        [InlineData("19", true)]
        [InlineData("20", true)]
        [InlineData("21", true)]
        [InlineData("22", true)]
        [InlineData("23", true)]
        [InlineData("24", true)]
        [InlineData("25", true)]
        [InlineData("26", true)]
        [InlineData("27", true)]
        [InlineData("28", true)]
        [InlineData("29", true)]
        [InlineData("30", true)]
        [InlineData("31", true)]
        [InlineData("32", true)]
        [InlineData("33", true)]
        [InlineData("34", true)]
        [InlineData("35", true)]
        [InlineData("36", true)]
        [InlineData("37", true)]
        [InlineData("38", true)]
        [InlineData("39", true)]
        [InlineData("40", true)]
        [InlineData("41", true)]
        [InlineData("42", true)]
        [InlineData("43", true)]
        [InlineData("44", true)]
        [InlineData("45", true)]
        [InlineData("46", true)]
        [InlineData("47", true)]
        [InlineData("48", true)]
        [InlineData("49", true)]
        [InlineData("50", true)]
        [InlineData("51", true)]
        [InlineData("52", true)]
        [InlineData("53", true)]
        [InlineData("54", true)]
        [InlineData("55", true)]
        [InlineData("56", true)]
        [InlineData("57", true)]
        [InlineData("58", true)]
        [InlineData("59", true)]
        [InlineData("60", true)]
        [InlineData("61", true)]
        [InlineData("62", true)]
        [InlineData("63", true)]
        [InlineData("64", true)]
        [InlineData("65", true)]
        [InlineData("66", true)]
        [InlineData("67", true)]
        [InlineData("68", true)]
        [InlineData("69", true)]
        [InlineData("70", true)]
        [InlineData("71", true)]
        [InlineData("72", true)]
        [InlineData("73", true)]
        [InlineData("74", true)]
        [InlineData("75", true)]
        [InlineData("76", false)]
        [InlineData("77", false)]
        [InlineData("78", false)]
        [InlineData("79", false)]
        [InlineData("80", false)]
        [InlineData("81", false)]
        [InlineData("82", false)]
        public void County(string county, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.AhCounty = county;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.AH_County, errorFields);
            }

        }


        //direction
        /// <summary>
        /// Tests the log direction field based on expected error flagging.
        /// </summary>
        /// <param name="direction">ArDOT Log and Antilog direction</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. false for errors</param>
        [Theory]
        [InlineData("A", true)]
        [InlineData("B", true)]
        [InlineData("C", false)]
        [InlineData("D", false)]
        [InlineData("1", false)]
        [InlineData("2", false)]
        [InlineData("3", false)]
        [InlineData("4", false)]
        [InlineData("5", false)]
        [InlineData("6", false)]
        [InlineData("7", false)]
        public void Direction(string direction, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = direction;
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.LOG_DIRECT, errorFields);
            }
        }

        /// <summary>
        /// Tests the route sign field based on expected validation errors
        /// </summary>
        /// <param name="routeSign">Route Sign field including values like interstate, US route, State route, County and City routes</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. false for errors</param>
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        [InlineData("6", false)]
        [InlineData("7", false)]
        [InlineData("8", false)]
        [InlineData("9", false)]
        [InlineData("10", false)]
        [InlineData("11", false)]
        [InlineData("12", false)]
        public void RouteSign(string routeSign, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.RouteSign = routeSign;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.RouteSign, errorFields);
            }
        }

        /// <summary>
        /// Tests the input TypeRoad for expected validation errors
        /// </summary>
        /// <param name="typeRoad">The Type Road field including values like Main lane, frontage road, ramp and cross connection</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. false for errors</param>
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", false)]
        [InlineData("3", true)]
        [InlineData("4", false)]
        [InlineData("5", true)]
        [InlineData("6", true)]
        [InlineData("7", true)]
        [InlineData("8", true)]
        [InlineData("9", false)]
        [InlineData("10", false)]
        [InlineData("11", false)]
        [InlineData("12", false)]
        [InlineData("13", false)]
        [InlineData("14", false)]
        public void TypeRoad(string typeRoad, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.TypeRoad = typeRoad;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.TypeRoad, errorFields);
            }

        }

        /// <summary>
        /// Tests Rural Urban Area field for expected error validations
        /// </summary>
        /// <param name="ruralUrbanArea">Rural UrbanArea Coded value as a string</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. false for errors</param>
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", false)]
        [InlineData("6", false)]
        [InlineData("7", false)]
        [InlineData("8", false)]
        [InlineData("9", false)]
        [InlineData("10", false)]
        [InlineData("11", false)]
        [InlineData("12", false)]
        public void RuralUrbanArea(string ruralUrbanArea, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.RuralUrbanArea = ruralUrbanArea;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.RuralUrbanArea, errorFields);
            }
        }

        /// <summary>
        /// Tests the Urban Area code for expected validation errors
        /// </summary>
        /// <param name="urbanCode">Urban Code as a 5 character string object</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. false for errors</param>
        [Theory]
        [InlineData("00000", true)]
        [InlineData("19801", true)]
        [InlineData("29494", true)]
        [InlineData("30925", true)]
        [InlineData("40213", true)]
        [InlineData("43345", true)]
        [InlineData("50392", true)]
        [InlineData("56116", true)]
        [InlineData("69454", true)]
        [InlineData("87193", true)]
        [InlineData("04984", false)]
        [InlineData("01010", false)]
        public void UrbanCode(string urbanCode, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.UrbanAreaCode = urbanCode;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                
                Assert.DoesNotContain(FieldsListModel.UrbanAreaCode, errorFields);
            } else
            {
                Assert.True(results.Count > 0);
                Assert.True(errorFields.Count > 0);
                Assert.Contains(FieldsListModel.UrbanAreaCode, errorFields);
            }
        }

        /// <summary>
        /// Tests the Surface Type field for expected validation errors
        /// </summary>
        /// <param name="surfaceType">Surface type coded value as a string</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. false for errors.</param>
        [Theory]
        [InlineData("0", true)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        [InlineData("6", true)]
        [InlineData("9", true)]
        [InlineData("10", true)]
        [InlineData("11", false)]
        [InlineData("12", false)]
        [InlineData("13", false)]
        [InlineData("14", false)]
        [InlineData("15", false)]
        [InlineData("16", false)]
        [InlineData("17", false)]
        [InlineData("18", false)]
        [InlineData("19", false)]
        [InlineData("20", false)]
        [InlineData("21", false)]
        [InlineData("22", false)]
        [InlineData("23", false)]
        [InlineData("24", false)]
        [InlineData("25", false)]
        [InlineData("26", false)]
        public void SurfaceType(string surfaceType, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.SurfaceType = surfaceType;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.SurfaceType, errorFields);
            }
        }

        /// <summary>
        /// Tests the extra lanes field for expected validation errors
        /// </summary>
        /// <param name="extraLanes">Extra Lanes coded value as a string object. Single digit number are not zero padded to be two characters</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. false for errors.</param>
        [Theory]
        [InlineData("0", true)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        [InlineData("6", true)]
        [InlineData("7", true)]
        [InlineData("8", false)]
        [InlineData("9", false)]
        [InlineData("10", false)]
        [InlineData("11", false)]
        [InlineData("12", false)]
        [InlineData("13", false)]
        [InlineData("14", false)]
        [InlineData("15", false)]
        [InlineData("16", false)]
        [InlineData("17", false)]
        [InlineData("18", false)]
        [InlineData("19", false)]
        [InlineData("20", false)]
        public void ExtraLanes(string extraLanes, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.ExtraLanes = extraLanes;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.ExtraLanes, errorFields);
            }
        }

        /// <summary>
        /// Tests type operation field for expected validation errors
        /// </summary>
        /// <param name="typeOperation">Type Operation coded value as a string object</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. false for errors.</param>
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", false)]
        [InlineData("6", false)]
        [InlineData("7", false)]
        [InlineData("8", false)]
        [InlineData("9", false)]
        public void TypeOperation(string typeOperation, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.TypeOperation = typeOperation;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.TypeOperation, errorFields);
            }
        }

        /// <summary>
        /// Tests access field for expected data validation errors
        /// </summary>
        /// <param name="access">Access coded value as a string</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. false for errors.</param>
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", false)]
        [InlineData("5", false)]
        [InlineData("6", false)]
        [InlineData("7", false)]
        [InlineData("8", false)]
        [InlineData("9", false)]
        [InlineData("10", false)]
        public void Access(string access, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.Access = access;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            }
            else 
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.Access, errorFields);
            }
        }

        /// <summary>
        /// Tests Median Type field for expected data validation errors
        /// </summary>
        /// <param name="medainType">Median Type field as a string object</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. false for errors.</param>
        [Theory]
        [InlineData("0", true)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        [InlineData("6", false)]
        [InlineData("7", false)]
        [InlineData("8", false)]
        public void MedianType(string medainType, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.MedianType = medainType;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.MedianType, errorFields);
            }
        }

        /// <summary>
        /// Tests the left shoulder type field for expected data validation errors.
        /// </summary>
        /// <param name="leftShoulderSurface">Left Shoulder Surface Type coded value (not zero padded) as a string</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. false for errors.</param>
        [Theory]
        [InlineData("0", true)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        [InlineData("6", true)]
        [InlineData("7", false)]
        [InlineData("8", false)]
        [InlineData("9", false)]
        [InlineData("10", false)]
        [InlineData("11", false)]
        [InlineData("12", false)]
        public void LeftShoulderSurface(string leftShoulderSurface, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.LeftShoulderSurface = leftShoulderSurface;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.LeftShoulderSurface, errorFields);
            }
        }



        /// <summary>
        /// Tests right should surface type field for expected data valdiation errors
        /// </summary>
        /// <param name="RightShoulderSurface">Right Shoulder Surface Type coded value (not zero padded) as a string</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. false for errors.</param>
        [Theory]
        [InlineData("0", true)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        [InlineData("6", true)]
        [InlineData("7", false)]
        [InlineData("8", false)]
        [InlineData("9", false)]
        [InlineData("10", false)]
        [InlineData("11", false)]
        [InlineData("12", false)]
        public void RightShoulderSurface(string RightShoulderSurface, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.RightShoulderSurface = RightShoulderSurface;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.RightShoulderSurface, errorFields);
            }
        }


        /// <summary>
        /// Tests functional Class field for expected data validation errors
        /// </summary>
        /// <param name="funcClass">Function Class coded value as a string object</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. false for errors.</param>
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        [InlineData("6", true)]
        [InlineData("7", true)]
        [InlineData("8", false)]
        [InlineData("9", false)]
        [InlineData("10", false)]
        [InlineData("11", false)]
        [InlineData("12", false)]
        [InlineData("13", false)]
        [InlineData("14", false)]
        public void FunctionalClass(string funcClass, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.FuncClass = funcClass;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.FuncClass, errorFields);
            }

        }

        /// <summary>
        /// tests the NHS field for expected data validation errors
        /// </summary>
        /// <param name="nhs">NHS coded value (not zero padded) as a string object </param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. False for errors.</param>
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
        [InlineData("13", false)]
        [InlineData("14", false)]
        [InlineData("15", false)]
        [InlineData("16", false)]
        [InlineData("17", false)]
        [InlineData("18", false)]
        public void Nhs(string nhs, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.Nhs = nhs;
            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.NHS, errorFields);
            }
        }

        /// <summary>
        /// Tests APHN field for expected data validation errors
        /// </summary>
        /// <param name="aphn">APHN coded value as a string</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. False for errors.</param>
        [Theory]
        [InlineData("0", true)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", false)]
        [InlineData("6", false)]
        [InlineData("7", false)]
        [InlineData("8", false)]
        [InlineData("9", false)]
        [InlineData("10", false)]
        [InlineData("11", false)]
        [InlineData("12", false)]
        [InlineData("13", false)]
        [InlineData("14", false)]
        [InlineData("15", false)]
        [InlineData("16", false)]
        [InlineData("17", false)]
        [InlineData("18", false)]
        [InlineData("19", false)]
        public void Aphn(string aphn, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.Aphn = aphn;
            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.APHN, errorFields);
            }
        }

        /// <summary>
        /// Tests Goverment Code for expected data validation errors
        /// </summary>
        /// <param name="govermentCode">Goverment Code coded-value as a string object (not zero padded to two characters)</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. False for errors.</param>
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", false)]
        [InlineData("4", true)]
        [InlineData("5", false)]
        [InlineData("6", false)]
        [InlineData("7", false)]
        [InlineData("8", false)]
        [InlineData("9", false)]
        [InlineData("10", false)]
        [InlineData("11", false)]
        [InlineData("21", true)]
        [InlineData("60", true)]
        [InlineData("63", true)]
        [InlineData("64", true)]
        [InlineData("66", true)]
        [InlineData("70", true)]
        [InlineData("72", true)]
        [InlineData("73", true)]
        [InlineData("74", true)]
        [InlineData("80", true)]
        public void GovermentCode(string govermentCode, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.GovermentCode = govermentCode;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.GovermentCode, errorFields);
            }
        }

        /// <summary>
        /// tests the special systems field for expected data validation errors
        /// </summary>
        /// <param name="specialSystems">Special Systems field as a coded value</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. False for errors.</param>
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", false)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        [InlineData("6", true)]
        [InlineData("7", true)]
        [InlineData("8", false)]
        [InlineData("9", true)]
        [InlineData("10", false)]
        [InlineData("11", false)]
        [InlineData("12", false)]
        [InlineData("13", false)]
        [InlineData("14", false)]
        [InlineData("15", false)]
        [InlineData("16", false)]
        [InlineData("17", false)]
        [InlineData("18", false)]
        [InlineData("19", false)]
        public void SpecialSystems(string specialSystems, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.SpecialSystems = specialSystems;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.SpecialSystems, errorFields);
            }
        }

        /// <summary>
        /// Tests the system status field for expected data validation errors related to coded values
        /// </summary>
        /// <param name="systemStatus">System Status coded value as string</param>
        /// <param name="expected">A boolean value indicating if errors are expected to be returned or not. true for no errors. False for errors.</param>
        [Theory]
        [InlineData("0", true)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", false)]
        [InlineData("4", false)]
        [InlineData("5", false)]
        [InlineData("6", false)]
        [InlineData("7", false)]
        [InlineData("8", false)]
        [InlineData("9", false)]
        [InlineData("10", false)]
        [InlineData("11", false)]
        [InlineData("12", false)]
        [InlineData("13", false)]
        [InlineData("14", false)]
        [InlineData("15", false)]
        public void SystemStatus(string systemStatus, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.SystemStatus = systemStatus;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.Empty(results);
                Assert.Empty(errorFields);
            } else
            {
                Assert.Single(results);
                Assert.Single(errorFields);
                Assert.Contains(FieldsListModel.SystemStatus, errorFields);
            }
        }

    }
}
