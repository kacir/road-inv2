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
    /// This class is a collection of various unit tests that check complex logical 
    /// relationship between different fields and logically valid number ranges for individual fields. 
    /// Check individual method docstrings for explanations of their complex logic.
    /// </summary>
    public class ValidationCodesUnitTest
    {
        /// <value> <c>_dbContext</c> - entiy framework context some description of some kind </value>
        public RoadInv.DB.roadinvContext _dbContext;
        /// <value> <c>validation</c> - instance needed in order to perform valdiations against things in the database </value>
        public RoadInv.Models.ValidationModel validation;

        public ValidationCodesUnitTest()
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
        /// Turns a list of string objects that are intended to be field names and builts them into a string. 
        /// The intent is this method helps build error messages used in other unit tests. This is only intended as a message helper.
        /// </summary>
        /// <param name="rawList">a string list object containing field names</param>
        /// <returns>a sting version of the inptu rawList object in a comma delinated format</returns>
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
        /// <summary>
        /// This tests validates errors related to redundancy between the NHS and RouteSign.
        /// The rule is if RouteSign = 1 then NHS must be 1.
        /// All Interstates (RouteSign 1) are part of the NHS. By extension all The status of the
        /// NHS field must be 1 - on NHS. If the RouteSign is 1 and NHS is 0 - Not NHS that is an issue
        /// Only applied to TypeRoad 1 - Mainlane due to ramp complexities.
        /// </summary>
        /// <param name="NHS">National Highway System coded value</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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
        /// <summary>
        /// This test validates errors recated to redundancy between APHN and Route Sign.
        /// All Interstate (RouteSign 1) are part of the APHN by default.
        /// All Interstates must be listed under APHN status 1 NHS because all Intstates are on the NHS.
        /// Only applied to TypeRoad 1 - Mainlane due to ramp complexities.
        /// </summary>
        /// <param name="APHN">APHN Coded value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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
        /// <summary>
        /// This one is a bit complicated of a rule for validation a specific APHN value combo.
        /// The previous rule took care of RouteSign 1 rules. This takes care of RouteSign 2 and 3 which are US and State routes.
        /// If a route is on the NHS and its on the on system, is must be listed under APHN status 1, on the NHS.
        /// Only applied to TypeRoad 1 - Mainlane due to ramp complexities.
        /// </summary>
        /// <param name="APHN">APHN coded value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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
        /// <summary>
        /// This one is fairly simple. There is a status of APHN 1 - NHS.
        /// All NHS routes must be on the APHN using coded value 1. If a route is not on 
        /// the NHS, indicated by NHS coded value 0, but the APHN value 1 one indicating its is on the NHS
        /// There is something wrong. It needs to launch an error.
        /// </summary>
        /// <param name="APHN">APHN coded value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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
        /// <summary>
        /// All NHS routes are automically part of STRATNET.
        /// Therefore if Special System is 9 - STRATNET then NHS must be 1 - on NHS
        /// </summary>
        /// <param name="specialSystem">Special Systems coded value as a string object</param>
        /// <param name="NHS">NHS coded value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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
                Assert.True(results.Count == 0, ValidationCodesUnitTest.AffectedFieldsMessage(errorFields));
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.SpecialSystems, errorFields);
                Assert.Contains(FieldsListModel.NHS, errorFields);
            }
        }

        //Both Direction # lanes
        // if TypeOperation = 4 then BothDirectionNumLane >= 2
        //page 39
        /// <summary>
        /// This tests compatability of the typeOperation field and bothDirectionNumLanes field.
        /// If a road is a divided highway (Type Operation 4). It would need at least two lanes. 
        /// One Log direction lane and one antilog direction lane. Thats a minimum total of two lanes
        /// By extension, the bothDirectionNunLanes field is a total of the log and anti-log lanes.
        /// Any divided highway should then have a bothDirectionNumLane field equal to or greater than 2.
        /// </summary>
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
        /// <summary>
        /// This tests compatability of the typeOperation field and bothDirectionNumLanes field.
        /// If a road is a divided highway (Type Operation 4). It would need at least two lanes. 
        /// One Log direction lane and one antilog direction lane. Thats a minimum total of two lanes
        /// By extension, the bothDirectionNunLanes field is a total of the log and anti-log lanes.
        /// Any divided highway should then have a bothDirectionNumLane field equal to or greater than 2.
        /// </summary>
        /// <param name="TypeOperation">TypeOperation coded value as a string object</param>
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

        /// <summary>
        /// This deals with simple math valdiations associated with the bothDirectionNumLanes and OneDirectionNumLanes fields in a divided highway
        /// The bothDirectionNumLanes field is a combination of both log and antilog directions. OneDirectionNumLanes is just the
        /// number of lanes for a single single. In theory,
        /// 
        /// OneDirectionNumLanes Antilog + OnDirectionNumLanes Log = BothDirectionNumLanes
        /// 
        /// If this is the case then BothDirectionNumLanes could never be bigger than OnDirectionNumLanes minus since the opposite side of the
        /// road should have at least one lane.
        /// 
        /// </summary>
        /// <param name="BothDirectionNumLanes">Number of lanes on both sides of the road of a divided highway in total. As a string object</param>
        /// <param name="OneDirectionNumLanes">Number of lanes on just a single side of the divided highway as a string object</param>
        /// <param name="Expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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

        /// <summary>
        /// This deal with simple math validations asscoiated with the BothDirectionNumLanes and 
        /// OnDirectionNumLanes fields in a non-divided highway.
        /// 
        /// In a non-divided highway, in theory both bothDirectionNumLanes and OneDirectionNumLanes should be equal to each other
        /// or the Both Directions lanes should be less than one direction numlanes
        /// </summary>
        /// <param name="BothDirectionNumLanes">Number of lanes on both sides of the road of a divided highway in total. As a string object</param>
        /// <param name="OneDirectionNumLanes">Number of lanes on just a single side of the divided highway as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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
        /// <summary>
        /// BothDirectionsNumber of Lanes must be greater than OneDirection number of lanes, only when its a divided highway.
        /// If its any other type operation like one-way, two way undivided or one-way couplet, both need to be equal to each other.
        /// This tests if the two lane field are not equal which type operations will cause flags to be launched.
        /// </summary>
        /// <param name="TypeOperation">Type Operation Coded-value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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

        /// <summary>
        /// If the one direction number of lanes is greater than both directions number of lanes, then
        /// its a divided highway. divided highways have medians. The median type must not be 0 - no median.
        /// </summary>
        /// <param name="MedianType">Median type coded-value as string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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

        /// <summary>
        ///  If one direction number of lanes is greare than both directions number of lanes, then
        ///  its a divided highway. all divided highways have medians. all medians have a width.
        /// </summary>
        /// <param name="medianWidth">Median Width as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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

        /// <summary>
        /// checks a single combination of NHS and APHN.
        /// if the APHN value 1 one, then the route is on the NHS.
        /// All NHS values except for 0 are valid combinations with APHN 1.
        /// </summary>
        /// <param name="NHS">NHS coded value as string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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

        /// <summary>
        /// Checks a single combination of NHS and APHN
        /// if NHS value indicates route is not on NHS, APHN can't equal code 1 (NHS). 
        /// This violates the definition of the coded value. This test the rule that
        /// errors that get launched with an APHN is not 1 but the NHS value is.
        /// </summary>
        /// <param name="NHS">NHS coded value as string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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

        /// <summary>
        /// APHN coded value 2 - Other Arerials is defined as being all routes that are functional class 2, 3 or 4 which are
        /// Other Freeways and Expressways and Other Principal Arterials. 
        /// 
        /// This unit test triggers error to validate if the APHN value is 2 Other Arterials try all
        /// Functional classes and test for expected values.
        /// </summary>
        /// <param name="funcClass">Functional Class coded-value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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
        /// <summary>
        /// Interstates always have full access control.
        /// Interstates are routeSign 1- Interstate. Interstates have ramps and other traffic control
        /// mechanisms which make the Access control value 1 - Full Control
        /// </summary>
        /// <param name="accessControl">Access Control coded-value as string object</param>
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

        /// <summary>
        /// All divided highways have full control access.
        /// This method tests different combinations with access 1- full control. only TypeOperation 4 - Divided highway
        /// Should return not return errors.
        /// </summary>
        /// <param name="typeOperation">Acess control coded-value as string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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

        /// <summary>
        /// If the median type indicates there is a median (everything but 0 = no median). Then its a divided highway
        /// If its a divided highway, the access control is full - code 1
        /// </summary>
        /// <param name="medianType">Median Type coded value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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

        /// <summary>
        /// if the median width is greater than 0, that indicates there is a median.
        /// If there is a median then, then its a divided highway. All divided highways are access control 1 - full control
        /// </summary>
        /// <param name="medianWidth">Median width as a string. No units and not zero padded.</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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
        /// <summary>
        /// tests a single invalid combination between type operation and access control
        /// all access control type 1- full control records must be type operation 4 - divided highway.
        /// full control can only be achieved on a divided highway.
        /// </summary>
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

        /// <summary>
        /// All divided highway have medians
        /// if the median width is zero that should cause an error with type operation 4 - divided highway.
        /// Divided highways should have median greater than zero.
        /// </summary>
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

        /// <summary>
        /// All divided highways have meidans
        /// If the meidan type is not 0 (no median). That indicates the type operation should be 4 -divided highway.
        /// If the median type is zero and the type operation is 4 divided highway, then an error should be launched.
        /// </summary>
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
        /// <summary>
        /// Tests different type operations while using the same median width which indicates its a divided highway (type operation 4).
        /// </summary>
        /// <param name="typeOperation">Type Operation as a coded value</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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

        /// <summary>
        /// Both median width and median type can suggest the existance or lack of a median.
        /// Both need to agree with each other. You can't have a median with of 0 but a median type of cable for instance.
        /// This tests the situation of a 12 ft median with different median types. Only the median type 0 - no median should return an error.
        /// </summary>
        /// <param name="medianType">Median Type coded value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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
        /// <summary>
        /// The validations do not allow a lane width greater than 15 feet.
        /// test tries various lane widths with expecte results based on the 15 feet max.
        /// </summary>
        /// <param name="laneWidth">Lane width as an integer</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
        [Theory]
        [InlineData(1, true)]
        [InlineData(5, true)]
        [InlineData(10, true)]
        [InlineData(11, true)]
        [InlineData(12, true)]
        [InlineData(6, true)]
        [InlineData(7, true)]
        [InlineData(8, true)]
        [InlineData(15, true)]
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

        /// <summary>
        /// surface width includes lanes inside of it. The surface width must be at least as big as the lane width. If not it should cause an error.
        /// </summary>
        /// <param name="laneWidth">Lane width in feet</param>
        /// <param name="surfaceWidth">Surface Width in feet</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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

        /// <summary>
        /// The surface width should always be larger than the lane width times the number of lanes for both directions.
        /// </summary>
        /// <param name="laneWidth">Lane width in feet</param>
        /// <param name="surfaceWidth">Surface width in feet</param>
        /// <param name="bothDirectionNumLanes">Both Directions Number of lanes</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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
        /// <summary>
        /// Roadway Width is always less thant the surface width. surfae width includes the shoulders.
        /// Roadway width does not. 
        /// 
        /// Test check multiple combo lengths of roadway width and surface width. 
        /// </summary>
        /// <param name="roadwayWidth">Roadway width in feet</param>
        /// <param name="surfaceWidth">Surface widht in feet</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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
        /// <summary>
        /// checks combinations of median type and type operation. Type operation 4 - divided 
        /// highway must have a median type that is not 0 - no-median. Also if median type is not equal to 0, then type operation must be 4.
        /// 
        /// </summary>
        /// <param name="medianType">Median Type coded value as a string object</param>
        /// <param name="typeOperation">Type Operation coded value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
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

        /// <summary>
        /// Year reconstructed must not be less than 1900 or greater than 2100. Its just a reasonabless range for inputs.
        /// Method tests different year based on this rule.
        /// </summary>
        /// <param name="yearRecon">Year road was last reconstructed (example overlay, fog seal, rebuild)</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
        [Theory]
        [InlineData("1900", true)]
        [InlineData("1966", true)]
        [InlineData("2001", true)]
        [InlineData("2032", true)]
        [InlineData("1982", true)]
        [InlineData("1990", true)]
        [InlineData("1919", true)]
        [InlineData("2062", true)]
        [InlineData("2132", false)]
        [InlineData("500000", false)]
        [InlineData("3300", false)]
        [InlineData("2300", false)]
        [InlineData("1619", false)]
        [InlineData("1500", false)]
        [InlineData("1782", false)]
        public void ValidYearReconstructed(string yearRecon, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.YearRecon = yearRecon;

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.yearRecon, errorFields);
                Assert.Single(errorFields);
            }

        }

        /// <summary>
        /// Year reconstructed must not be less than 1900 or greater than 2100. Its just a reasonabless range for inputs.
        /// Method tests different year based on this rule.
        /// </summary>
        /// <param name="yearBuilt">Year First Built as string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
        [Theory]
        [InlineData("1900", true)]
        [InlineData("1966", true)]
        [InlineData("2001", true)]
        [InlineData("2032", true)]
        [InlineData("1982", true)]
        [InlineData("1990", true)]
        [InlineData("1919", true)]
        [InlineData("2062", true)]
        [InlineData("2132", false)]
        [InlineData("500000", false)]
        [InlineData("3300", false)]
        [InlineData("2300", false)]
        [InlineData("1619", false)]
        [InlineData("1500", false)]
        [InlineData("1782", false)]
        public void ValidYearBuilt(string yearBuilt, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.YearBuilt = yearBuilt;

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
                Assert.Contains(FieldsListModel.YearBuilt, errorFields);
                Assert.Single(errorFields);
            }

        }

        /// <summary>
        /// Testing for situation where there is no median where meidan type and median width are filled in. There should not be any validation errors thrown.
        /// </summary>
        [Fact]
        public void NoMedianCombo()
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;

            segment.MedianType = "0";
            segment.MedianWidth = "000";

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            Assert.Empty(results);
        }

        /// <summary>
        /// This is a test that is designed to fail every time. You specify a record id and then it runs validation against it.
        /// I generally use this as a debugging tool when I find a troublesome record in the main interface but I want to drill 
        /// down further as to why was an error caused in the first place.
        /// </summary>
        [Fact]
        public void SpecificRecorTest()
        {
            int recordid = 1446487;
            var segment = this._dbContext.RoadInvs.Find(recordid);

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);

            Assert.True(results.Count == 0);
        }
    }
}
