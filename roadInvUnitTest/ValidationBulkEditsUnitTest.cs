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
    /// <summary>
    /// Unit tests to determine if the bulk editing backend functionality is working. 
    /// This is the backend functionality that is pulled on in the system changes page of the web interface
    /// </summary>
    public class ValidationBulkEditsUnitTest
    {
        /// <value> <c>_dbContext</c> - entiy framework context some description of some kind </value>
        public RoadInv.DB.roadinvContext _dbContext;
        /// <value> <c>_bulkEditor</c> - Instance is required to perform bulk edit logmile calculations </value>
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

            _bulkEditor = new RoadInv.Models.BulkEditModel(this._dbContext);
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
        /// This is a helper function used by unit tests. This method creates 3 records in the roadInv table with the route ID "16xFAKENAMExzzxA". 
        /// If records already exist witht the same route id it deletes them. It is intended that a test can modify the FAKENAME records during 
        /// test bulk edit operations and then reset to the original state when the next test is run.
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
        /// This method tests the FakeRouteGenerator. If the FakeRouteGenerator method is incorrectly 
        /// running then the results of all other unit tests will be incorrect.
        /// </summary>
        [Fact]
        public void TestRouteGenerator()
        {
            FakeRouteGenerator();

            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "74xFAKENAMEx0xA" select record;
            Assert.NotEmpty(fakeRoutes);
            Assert.True(fakeRoutes.Count() == 3);
        }

        /// <summary>
        /// Tests the senario where the input bulk edit range does not effect any records at all because there are no records for that route id. 
        /// If this happens it should fail with an exception.
        /// </summary>
        [Fact]
        public void NoRecordsImpacted()
        {
            FakeRouteGenerator();
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "16xFAKENAMExzzxA" select record;

            bool failed;
            try
            {
                this._bulkEditor.BulkEdit("74xFAKENAMExzzxA", (decimal)0.25, (decimal)0.5);
                failed = false;
            }
            catch (Exception)
            {
                failed = true;
            }
            Assert.True(failed);
        }

        /// <summary>
        /// Test the senario where the input route id does have some records but the specific range does not include any records. The result should end in an exception rather than no records returned.
        /// </summary>
        [Fact]
        public void OutOfRange()
        {
            FakeRouteGenerator();
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "74xFAKENAMEx0xA" select record;

            bool failed;
            try
            {
                this._bulkEditor.BulkEdit("74xFAKENAMExzzxA", 50, 55);
                failed = false;
            }
            catch (Exception)
            {
                failed = true;
            }
            Assert.True(failed);
        }

        /// <summary>
        /// Tests a specific bulk edit that only effects one record where the bulk specificed range exactly matches the record's range.
        /// In this specific case the first record in a seris is selected.
        /// </summary>
        [Fact]
        public void OneRecordNoSplitting1()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("74xFAKENAMEx0xA", (decimal)0.25, (decimal)0.5);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "74xFAKENAMEx0xA" orderby record.AhBlm select record;

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
        
        /// <summary>
        /// Tests a specific bulk edit that only effects one record where the bulk specificed range exactly matches the record's range.
        /// In this specific case the middle record in a seris is selected.
        /// </summary>
        [Fact]
        public void OneRecordNoSplitting2()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("74xFAKENAMEx0xA", (decimal)0.5, 1);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "74xFAKENAMEx0xA" orderby record.AhBlm select record;

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

        /// <summary>
        /// Tests a specific bulk edit that only effects one record where the bulk specificed range exactly matches the record's range.
        /// In this specific case the last record in a seris is selected.
        /// </summary>
        [Fact]
        public void OneRecordNoSplitting3()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("74xFAKENAMEx0xA", 1, (decimal)1.5);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "74xFAKENAMEx0xA" orderby record.AhBlm select record;

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

        /// <summary>
        /// Tests when the bulk edit range specificed includes the first record and some space before the roadway inventory's record's blm.
        /// Only one direct should be effected and no records should be split.
        /// </summary>
        [Fact]
        public void UnderShootOneRecordEffected()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("74xFAKENAMEx0xA", -1, (decimal)0.5);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "74xFAKENAMEx0xA" orderby record.AhBlm select record;

            Assert.True(effectedRows.Count() == 1);
            Assert.True(effectedRows.First().AhBlm == (decimal)0.25);
            Assert.True(effectedRows.First().AhElm == (decimal)0.5);

            Assert.True(fakeRoutes.Count() == 3);
        }

        //overshoot - one record only
        /// <summary>
        /// tests when the the bulk edit range goes beyond the last record but fully includes just the last record. Only one record 
        /// should be effected and no records should be split.
        /// </summary>
        [Fact]
        public void OvershootOneRecordEffected()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("74xFAKENAMEx0xA", 1, 2);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "74xFAKENAMEx0xA" orderby record.AhBlm select record;

            Assert.True(effectedRows.Count() == 1);
            Assert.True(effectedRows.First().AhBlm == 1);
            Assert.True(effectedRows.First().AhElm == (decimal)1.5);
            Assert.True(fakeRoutes.Count() == 3);

        }

        /// <summary>
        /// Tests senario when the bulk edit range does beyond both the blm and elm of the roadway inventory records. 
        /// It should include all three test records and no records should be split. All three should be redesignated
        /// </summary>
        [Fact]
        public void ContainsMultipleRecords()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("74xFAKENAMEx0xA", -1, 5);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "74xFAKENAMEx0xA" orderby record.AhBlm select record;

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

        /// <summary>
        /// Senario tests when input range split the first record in a roadway inventory route. result should split the first record so there are 4 records in total.
        /// A new record should be generated and the old recor's BLM and ELM should be changed accordingly.
        /// </summary>
        [Fact]
        public void Undershoot()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("74xFAKENAMEx0xA", (decimal)0.25, (decimal)0.3);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "74xFAKENAMEx0xA" orderby record.AhBlm select record;

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

        /// <summary>
        /// Test senario where input bulk edit range fits inside of the first record of a roadway inventory route. Single record should be split into three.
        /// Two new records should be generated and the single existing record should be ajusted accordingly.
        /// </summary>
        [Fact]
        public void Undershoot2()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("74xFAKENAMEx0xA", (decimal)0.002, (decimal)0.3);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "74xFAKENAMEx0xA" orderby record.AhBlm select record;

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

        /// <summary>
        /// Test bulk edit range matching the last roadway inventory records ELM but overshooting the BLM of the 
        /// same record resulting the a record that needs to be split.
        /// </summary>
        [Fact]
        public void Overshoot()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("74xFAKENAMEx0xA", (decimal)1.25, (decimal)1.5);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "74xFAKENAMEx0xA" orderby record.AhBlm select record;

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

        /// <summary>
        /// Test senario where bulk edit range split the last record and overshoots that last record's elm. should result in a split record.
        /// </summary>
        [Fact]
        public void Overshoot2()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("74xFAKENAMEx0xA", (decimal)1.25, (decimal)4);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "74xFAKENAMEx0xA" orderby record.AhBlm select record;

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

        /// <summary>
        /// Tests when bulk edit range is inside of the middle record of the roadway inventory. 
        /// Middle roadway inventory record should be split into three different records. Two new records and a modification of one record.
        /// </summary>
        [Fact]
        public void SplitMiddleRecordTwice()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("74xFAKENAMEx0xA", (decimal)0.55, (decimal)0.9);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "74xFAKENAMEx0xA" orderby record.AhBlm select record;

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


        /// <summary>
        /// Test partially splits two different records. The first record and the middle record. Bulk edit range partially straddles the first two records.
        /// This should result in two new records and two records being modified.
        /// </summary>
        [Fact]
        public void SplitTwoRecords()
        {
            FakeRouteGenerator();
            var effectedRows = this._bulkEditor.BulkEdit("74xFAKENAMEx0xA", (decimal)0.4, (decimal)0.6);
            var fakeRoutes = from record in this._dbContext.RoadInvs where record.AhRoadId == "74xFAKENAMEx0xA" orderby record.AhBlm select record;

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
