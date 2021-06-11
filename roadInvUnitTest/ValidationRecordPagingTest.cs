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
    /// Class tests underlying C sharp models that determine the next record when 
    /// paging through the edit segment pages from one record to the next.
    /// </summary>
    public class ValidationRecordPagingTest
    {
        /// <summary>
        /// Entity framework database context object need to interact with roadway inventory database.
        /// </summary>
        public RoadInv.DB.roadinvContext _dbContext;


        public ValidationRecordPagingTest()
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
        /// Method is used to create consistant records in the database to test the paging functionality. 
        /// This ensures the tests will run with the same resuts every time even if the records were deleted, modified or added to.
        /// Method deletes all existing records with the same name and replaces them with a set of expected segment records.
        /// </summary>
        public void FakeRouteGenerator()
        {
            //full ah_RoadID is 16xFAKENAMEx1xA
            var originSegment = this._dbContext.RoadInvs.Find(1482104);
            string fakeRouteName = "FAKENAME";
            string nhsStatus = "1";

            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoute == fakeRouteName | record.AhRoadId == "16xFAKENAMExzzxA" select record;
            foreach (var row in fakeRoutes)
            {
                this._dbContext.RoadInvs.Remove(row);
            }

            var clone1 = RoadInv.Models.ErrorItemBulkModel.CloneSegment(originSegment);
            clone1.AhBlm = (decimal)0.25;
            clone1.AhElm = (decimal?)0.5;
            clone1.AhRoute = fakeRouteName;
            clone1.Nhs = nhsStatus;

            var clone2 = RoadInv.Models.ErrorItemBulkModel.CloneSegment(originSegment);
            clone2.AhBlm = (decimal?)0.5;
            clone2.AhElm = 1;
            clone2.AhRoute = fakeRouteName;
            clone2.Nhs = nhsStatus;

            var clone3 = RoadInv.Models.ErrorItemBulkModel.CloneSegment(originSegment);
            clone3.AhBlm = 1;
            clone3.AhElm = (decimal?)1.5;
            clone3.AhRoute = fakeRouteName;
            clone3.Nhs = nhsStatus;

            _dbContext.RoadInvs.Add(clone1);
            _dbContext.RoadInvs.Add(clone2);
            _dbContext.RoadInvs.Add(clone3);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Test attempts to navigate from the middle records to the first record. Assentually paging backwards. The first record should be returned.
        /// </summary>
        [Fact]
        public void PageBefore()
        {
            FakeRouteGenerator();
            string fakeRouteName = "FAKENAME";
            var sourceRecord = from record in this._dbContext.RoadInvs where record.AhRoute == fakeRouteName & record.AhBlm == (decimal)0.5 select record;

            var segmentOrderer = new RoadInv.Models.SegmentOrderModel(_dbContext);
            var recordid = segmentOrderer.Before(sourceRecord.First().Id);

            var actualBeforeRecord = from record in this._dbContext.RoadInvs where record.AhRoute == fakeRouteName & record.AhBlm == (decimal)0.25 select record;

            Assert.True(actualBeforeRecord.First().Id == recordid);
        }

        /// <summary>
        /// Test attempts to navigate from the middle record to the last record in the route. The last record should be returned.
        /// </summary>
        [Fact]
        public void PageAfter()
        {
            FakeRouteGenerator();
            string fakeRouteName = "FAKENAME";
            var sourceRecord = from record in this._dbContext.RoadInvs where record.AhRoute == fakeRouteName & record.AhBlm == (decimal)0.5 select record;

            var segmentOrderer = new RoadInv.Models.SegmentOrderModel(_dbContext);
            var recordid = segmentOrderer.After(sourceRecord.First().Id);

            var actualAfterRecord = from record in this._dbContext.RoadInvs where record.AhRoute == fakeRouteName & record.AhBlm == 1 select record;

            Assert.True(actualAfterRecord.First().Id == recordid);
        }

        /// <summary>
        /// Test attempts to navigate from the last record in the route to a record after it. 
        /// There is on record after it so the method should return the route id of -1 to indicate there is no record after the current record.
        /// </summary>
        [Fact]
        public void PageAfter_NoRecord()
        {
            FakeRouteGenerator();
            string fakeRouteName = "FAKENAME";
            var sourceRecord = from record in this._dbContext.RoadInvs where record.AhRoute == fakeRouteName & record.AhBlm == (decimal)1 select record;

            var segmentOrderer = new RoadInv.Models.SegmentOrderModel(_dbContext);
            var recordid = segmentOrderer.After(sourceRecord.First().Id);

            Assert.True(recordid == -1);
        }

        /// <summary>
        /// Test attempts to navigate from the first record in the route to a route that is before it. 
        /// There is no record before the first record so the function should return a route id of -1 
        /// to indicate there is no before record.
        /// </summary>
        [Fact]
        public void PageBefore_NoRecord()
        {
            FakeRouteGenerator();
            string fakeRouteName = "FAKENAME";
            var sourceRecord = from record in this._dbContext.RoadInvs where record.AhRoute == fakeRouteName & record.AhBlm == (decimal)0.25 select record;

            var segmentOrderer = new RoadInv.Models.SegmentOrderModel(_dbContext);
            var recordid = segmentOrderer.Before(sourceRecord.First().Id);

            Assert.True(recordid == -1);
        }


    }
}
