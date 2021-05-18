using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RoadInv.DB;
using RoadInv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace roadInvUnitTest
{
    public class ValidationBulkEditsUnitTest
    {
        public RoadInv.DB.roadinvContext _dbContext;
        public RoadInv.Models.ValidationModel validation;
        public RoadInv.Models.BulkEditModel _bulkEditor;

        public ValidationBulkEditsUnitTest()
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
            _bulkEditor = new RoadInv.Models.BulkEditModel(this._dbContext);
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
            var originSegment = this._dbContext.RoadInvs.Find(1014831);
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
        public void TestRouteGenerator()
        {
            FakeRouteGenerator();

            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "16xFAKENAMEx1xA" select record;
            Assert.NotEmpty(fakeRoutes);
            Assert.True(fakeRoutes.Count() == 3);
        }

        //no records effected error
        [Fact]
        public void NoRecordsImpacted()
        {
            FakeRouteGenerator();
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "16xFAKENAMExzzxA" select record;

            bool failed;
            try
            {
                this._bulkEditor.BulkEdit("16xFAKENAMExzzxA", (decimal)0.25, (decimal)0.5);
                failed = false;
            }
            catch (Exception)
            {
                failed = true;
            }
            Assert.True(failed);
        }

        [Fact]
        public void OutOfRange()
        {
            FakeRouteGenerator();
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "16xFAKENAMEx1xA" select record;

            bool failed;
            try
            {
                this._bulkEditor.BulkEdit("16xFAKENAMExzzxA", 50, 55);
                failed = false;
            }
            catch (Exception)
            {
                failed = true;
            }
            Assert.True(failed);
        }

        //one record effected - no splitting needed
        [Fact]
        public void OneRecordNoSplitting1()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("16xFAKENAMEx1xA", (decimal)0.25, (decimal)0.5);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "16xFAKENAMEx1xA" orderby record.AhBlm select record;

            Assert.True(effectedRows.Count() == 1);
            Assert.True(effectedRows.First().AhBlm == (decimal)0.25);
            Assert.True(effectedRows.First().AhElm == (decimal)0.5);

            int counter = 1;
            foreach (var row in fakeRoutes)
            {
                if (counter == 1)
                {
                    Assert.Equal(0.25, (double)row.AhBlm);
                    Assert.Equal(0.5, (double)row.AhElm);
                }
                if (counter == 2)
                {
                    Assert.Equal(0.5, (double)row.AhBlm);
                    Assert.Equal(1, (double)row.AhElm);
                }
                if (counter == 3)
                {
                    Assert.Equal(1, (double)row.AhBlm);
                    Assert.Equal(1.5, (double)row.AhElm);
                }

                counter += 1;
            }
        }

        [Fact]
        public void OneRecordNoSplitting2()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("16xFAKENAMEx1xA", (decimal)0.5, 1);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "16xFAKENAMEx1xA" orderby record.AhBlm select record;

            Assert.True(effectedRows.Count() == 1);
            Assert.True(effectedRows.First().AhBlm == (decimal)0.5);
            Assert.True(effectedRows.First().AhElm == (decimal)1);

            int counter = 1;
            foreach (var row in fakeRoutes)
            {
                if (counter == 1)
                {
                    Assert.Equal(0.25, (double)row.AhBlm);
                    Assert.Equal(0.5, (double)row.AhElm);
                }
                if (counter == 2)
                {
                    Assert.Equal(0.5, (double)row.AhBlm);
                    Assert.Equal(1, (double)row.AhElm);
                }
                if (counter == 3)
                {
                    Assert.Equal(1, (double)row.AhBlm);
                    Assert.Equal(1.5, (double)row.AhElm);
                }

                counter += 1;
            }
        }

        [Fact]
        public void OneRecordNoSplitting3()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("16xFAKENAMEx1xA", (decimal)1, (decimal)1.5);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "16xFAKENAMEx1xA" orderby record.AhBlm select record;

            Assert.True(effectedRows.Count() == 1);
            Assert.True(effectedRows.First().AhBlm == (decimal)1);
            Assert.True(effectedRows.First().AhElm == (decimal)1.5);

            int counter = 1;
            foreach (var row in fakeRoutes)
            {
                if (counter == 1)
                {
                    Assert.Equal(0.25, (double)row.AhBlm);
                    Assert.Equal(0.5, (double)row.AhElm);
                }
                if (counter == 2)
                {
                    Assert.Equal(0.5, (double)row.AhBlm);
                    Assert.Equal(1, (double)row.AhElm);
                }
                if (counter == 3)
                {
                    Assert.Equal(1, (double)row.AhBlm);
                    Assert.Equal(1.5, (double)row.AhElm);
                }

                counter += 1;
            }
        }

        //undershoot - one record only
        [Fact]
        public void UnderShootOneRecordEffected()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("16xFAKENAMEx1xA", -1, (decimal)0.5);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "16xFAKENAMEx1xA" orderby record.AhBlm select record;

            Assert.True(effectedRows.Count() == 1);
            Assert.True(effectedRows.First().AhBlm == (decimal)0.25);
            Assert.True(effectedRows.First().AhElm == (decimal)0.5);

            Assert.True(fakeRoutes.Count() == 3);
        }

        //overshoot - one record only
        [Fact]
        public void OvershootOneRecordEffected()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("16xFAKENAMEx1xA", 1, 2);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "16xFAKENAMEx1xA" orderby record.AhBlm select record;

            Assert.True(effectedRows.Count() == 1);
            Assert.True(effectedRows.First().AhBlm == 1);
            Assert.True(effectedRows.First().AhElm == (decimal)1.5);
            Assert.True(fakeRoutes.Count() == 3);

        }

        //entirely contains multiple records
        [Fact]
        public void ContainsMultipleRecords()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("16xFAKENAMEx1xA", -1, 5);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "16xFAKENAMEx1xA" orderby record.AhBlm select record;

            Assert.True(effectedRows.Count() == 3);
            Assert.True(effectedRows.First().AhBlm == (decimal)0.25);
            Assert.True(fakeRoutes.Count() == 3);

            int counter = 1;
            foreach (var row in fakeRoutes)
            {
                if (counter == 1)
                {
                    Assert.Equal(0.25, (double)row.AhBlm);
                    Assert.Equal(0.5, (double)row.AhElm);
                }
                if (counter == 2)
                {
                    Assert.Equal(0.5, (double)row.AhBlm);
                    Assert.Equal(1, (double)row.AhElm);
                }
                if (counter == 3)
                {
                    Assert.Equal(1, (double)row.AhBlm);
                    Assert.Equal(1.5, (double)row.AhElm);
                }

                counter += 1;
            }
        }

        [Fact]
        public void Undershoot()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("16xFAKENAMEx1xA", (decimal)0.25, (decimal)0.3);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "16xFAKENAMEx1xA" orderby record.AhBlm select record;

            Assert.True(effectedRows.Count() == 1);
            Assert.True(effectedRows.First().AhBlm == (decimal)0.25);
            Assert.True(effectedRows.First().AhElm == (decimal)0.3);
            Assert.True(fakeRoutes.Count() == 4);

            int counter = 1;
            foreach (var row in fakeRoutes)
            {
                if (counter == 1)
                {
                    Assert.Equal(0.25, (double)row.AhBlm);
                    Assert.Equal(0.3, (double)row.AhElm);
                }
                if (counter == 2)
                {
                    Assert.Equal(0.3, (double)row.AhBlm);
                    Assert.Equal(0.5, (double)row.AhElm);
                }
                if (counter == 3)
                {
                    Assert.Equal(0.5, (double)row.AhBlm);
                    Assert.Equal(1, (double)row.AhElm);
                }
                if (counter == 4)
                {
                    Assert.Equal(1, (double)row.AhBlm);
                    Assert.Equal(1.5, (double)row.AhElm);
                }

                counter += 1;
            }
        }

        [Fact]
        public void Undershoot2()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("16xFAKENAMEx1xA", (decimal)0.002, (decimal)0.3);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "16xFAKENAMEx1xA" orderby record.AhBlm select record;

            Assert.True(effectedRows.Count() == 1);
            Assert.True(effectedRows.First().AhBlm == (decimal)0.25);
            Assert.True(effectedRows.First().AhElm == (decimal)0.3);
            Assert.True(fakeRoutes.Count() == 4);

            int counter = 1;
            foreach (var row in fakeRoutes)
            {
                if (counter == 1)
                {
                    Assert.Equal(0.25, (double)row.AhBlm);
                    Assert.Equal(0.3, (double)row.AhElm);
                }
                if (counter == 2)
                {
                    Assert.Equal(0.3, (double)row.AhBlm);
                    Assert.Equal(0.5, (double)row.AhElm);
                }
                if (counter == 3)
                {
                    Assert.Equal(0.5, (double)row.AhBlm);
                    Assert.Equal(1, (double)row.AhElm);
                }
                if (counter == 4)
                {
                    Assert.Equal(1, (double)row.AhBlm);
                    Assert.Equal(1.5, (double)row.AhElm);
                }

                counter += 1;
            }
        }

        [Fact]
        public void Overshoot()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("16xFAKENAMEx1xA", (decimal)1.25, (decimal)1.5);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "16xFAKENAMEx1xA" orderby record.AhBlm select record;

            Assert.True(effectedRows.Count() == 1);
            Assert.True(effectedRows.First().AhBlm == (decimal)1.25);
            Assert.True(effectedRows.First().AhElm == (decimal)1.5);
            Assert.True(fakeRoutes.Count() == 4);

            int counter = 1;
            foreach (var row in fakeRoutes)
            {
                if (counter == 1)
                {
                    Assert.Equal(0.25, (double)row.AhBlm);
                    Assert.Equal(0.5, (double)row.AhElm);
                }
                if (counter == 2)
                {
                    Assert.Equal(0.5, (double)row.AhBlm);
                    Assert.Equal(1, (double)row.AhElm);
                }
                if (counter == 3)
                {
                    Assert.Equal(1, (double)row.AhBlm);
                    Assert.Equal(1.25, (double)row.AhElm);
                }
                if (counter == 4)
                {
                    Assert.Equal(1.25, (double)row.AhBlm);
                    Assert.Equal(1.5, (double)row.AhElm);
                }
                counter += 1;
            }

        }

        [Fact]
        public void Overshoot2()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("16xFAKENAMEx1xA", (decimal)1.25, (decimal)4);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "16xFAKENAMEx1xA" orderby record.AhBlm select record;

            Assert.True(effectedRows.Count() == 1);
            Assert.True(effectedRows.First().AhBlm == (decimal)1.25);
            Assert.True(effectedRows.First().AhElm == (decimal)1.5);
            Assert.True(fakeRoutes.Count() == 4);

            int counter = 1;
            foreach (var row in fakeRoutes)
            {
                if (counter == 1)
                {
                    Assert.Equal(0.25, (double)row.AhBlm);
                    Assert.Equal(0.5, (double)row.AhElm);
                }
                if (counter == 2)
                {
                    Assert.Equal(0.5, (double)row.AhBlm);
                    Assert.Equal(1, (double)row.AhElm);
                }
                if (counter == 3)
                {
                    Assert.Equal(1, (double)row.AhBlm);
                    Assert.Equal(1.25, (double)row.AhElm);
                }
                if (counter == 4)
                {
                    Assert.Equal(1.25, (double)row.AhBlm);
                    Assert.Equal(1.5, (double)row.AhElm);
                }
                counter += 1;
            }

        }

        [Fact]
        public void SplitMiddleRecordTwice()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("16xFAKENAMEx1xA", (decimal)0.55, (decimal)0.9);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "16xFAKENAMEx1xA" orderby record.AhBlm select record;

            Assert.True(effectedRows.Count() == 1);
            Assert.True(effectedRows.First().AhBlm == (decimal)0.55);
            Assert.True(effectedRows.First().AhElm == (decimal)0.9);
            Assert.True(fakeRoutes.Count() == 5);

            int counter = 1;
            foreach (var row in fakeRoutes)
            {
                if (counter == 1)
                {
                    Assert.Equal(0.25, (double)row.AhBlm);
                    Assert.Equal(0.5, (double)row.AhElm);
                }
                if (counter == 2)
                {
                    Assert.Equal(0.5, (double)row.AhBlm);
                    Assert.Equal(0.55, (double)row.AhElm);
                }
                if (counter == 3)
                {
                    Assert.Equal(0.55, (double)row.AhBlm);
                    Assert.Equal(0.9, (double)row.AhElm);
                }
                if (counter == 4)
                {
                    Assert.Equal(0.9, (double)row.AhBlm);
                    Assert.Equal(1, (double)row.AhElm);
                }
                if (counter == 5)
                {
                    Assert.Equal(1, (double)row.AhBlm);
                    Assert.Equal(1.5, (double)row.AhElm);
                }

                counter += 1;

            }

            //split two seperate records
        }


        [Fact]
        public void SplitTwoRecords()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("16xFAKENAMEx1xA", (decimal)0.4, (decimal)0.6);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "16xFAKENAMEx1xA" orderby record.AhBlm select record;

            Assert.True(effectedRows.Count() == 2);
            Assert.True(fakeRoutes.Count() == 5);

            int counter = 1;
            foreach (var row in fakeRoutes)
            {
                if (counter == 1)
                {
                    Assert.Equal(0.25, (double)row.AhBlm);
                    Assert.Equal(0.4, (double)row.AhElm);
                }
                if (counter == 2)
                {
                    Assert.Equal(0.4, (double)row.AhBlm);
                    Assert.Equal(0.5, (double)row.AhElm);
                }
                if (counter == 3)
                {
                    Assert.Equal(0.5, (double)row.AhBlm);
                    Assert.Equal(0.6, (double)row.AhElm);
                }
                if (counter == 4)
                {
                    Assert.Equal(0.6, (double)row.AhBlm);
                    Assert.Equal(1, (double)row.AhElm);
                }
                if (counter == 5)
                {
                    Assert.Equal(1, (double)row.AhBlm);
                    Assert.Equal(1.5, (double)row.AhElm);
                }
                counter += 1;
            }
        }
    }
}
