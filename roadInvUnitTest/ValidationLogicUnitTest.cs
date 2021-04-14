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

        private List<string> AffectedFields(List<RoadInv.Models.ErrorItemModel> rawList)
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

        private string AffectedFieldsMessage(List<string> rawList)
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
            var errorFields = this.AffectedFields(results);

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
            var errorFields = this.AffectedFields(results);
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
            var errorFields = this.AffectedFields(results);
            Assert.Contains(FieldsListModel.AH_BLM, errorFields);
            Assert.Contains(FieldsListModel.AH_ELM, errorFields);
            Assert.True(errorFields.Count == 2, "Extra errors around BLM and ELM equaling each other");

            logger.WriteLine("fields flagg in this operation are the following " + AffectedFieldsMessage(errorFields));
        }

        [Theory]
        [InlineData(5 , 0)]
        public void logmileFlipped(decimal blm, decimal elm)
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
            var errorFields = this.AffectedFields(results);
            logger.WriteLine("fields flagg in this operation are the following " + AffectedFieldsMessage(errorFields));
        }

        
        //invalid Route characters

    }
}
