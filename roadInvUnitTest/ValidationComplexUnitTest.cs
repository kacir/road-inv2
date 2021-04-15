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
        public void rulePG43A1(string NHS, bool expected )
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12X";
            segment.LogDirect = "A";
            segment.AhBlm = 0;
            segment.AhElm = (decimal?)0.5;
            segment.TypeRoad = "1";
            segment.Nhs = NHS;
            segment.RouteSign = "1";

            ValidationModel.CleanAttr(segment);
            var results = validation.FindErrors(segment);
            var errorFields = AffectedFields(results);

            if (expected)
            {
                Assert.True(errorFields.Count == 0);
            } else
            {
                Assert.True(errorFields.Count == 3);
                Assert.Contains(FieldsListModel.NHS, errorFields);
                Assert.Contains(FieldsListModel.RouteSign, errorFields);
                Assert.Contains(FieldsListModel.TypeRoad, errorFields);
            }
        }

        [Theory]
        [InlineData("1", true)]
        [InlineData("2", false)]
        [InlineData("3", false)]
        [InlineData("4", false)]
        public void rulePG43A2(string APHN, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12X";
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
                Assert.True(errorFields.Count == 0);
            }
            else
            {
                Assert.True(errorFields.Count == 3, AffectedFieldsMessage(errorFields));
                Assert.Contains(FieldsListModel.APHN, errorFields);
                Assert.Contains(FieldsListModel.RouteSign, errorFields);
                Assert.Contains(FieldsListModel.TypeRoad, errorFields);
            }
        }


        /*If RouteSign = 2 or 3 and TypeRoad = 1 if NHS <> 0 then APHN = 1*/
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", false)]
        [InlineData("3", false)]
        [InlineData("4", false)]
        public void rulePG34B(string APHN, bool expected)
        {
            var segment = new RoadInv.DB.RoadInv();
            segment.AhCounty = "60";
            segment.AhRoute = "ARNOLDDRIVE1";
            segment.AhSection = "12X";
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
        public void ruleGP34C(string APHN, bool expected)
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
                Assert.True(results.Count == 0);
            } else
            {
                Assert.True(results.Count == 1);
                Assert.Contains(FieldsListModel.SpecialSystems, errorFields);
                Assert.Contains(FieldsListModel.NHS, errorFields);
            }
        }

        //Both Direction # lanes

        //page 39

    }
}
