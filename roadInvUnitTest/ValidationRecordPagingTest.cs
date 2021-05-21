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
    public class ValidationRecordPagingTest
    {
        public RoadInv.DB.roadinvContext _dbContext;
        public RoadInv.Models.ValidationModel validation;


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

            validation = new RoadInv.Models.ValidationModel(_dbContext);
        }

        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.test.json")
                .Build();
            return config;
        }

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
