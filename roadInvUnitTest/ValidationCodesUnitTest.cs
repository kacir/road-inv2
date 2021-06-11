using System;
using Xunit;
using RoadInv.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace roadInvUnitTest
{
    /// <summary>
    /// Class contains collection of unit tests that see if the allowed field codes have been properly loaded into the validation class on itialization.
    /// </summary>
    public class RoadInvUnitTest
    {
        /// <summary>
        /// The entity framework context object
        /// </summary>
        public RoadInv.DB.roadinvContext _dbContext;
        /// <summary>
        /// Validation object that stores the coded values for each field
        /// </summary>
        public RoadInv.Models.ValidationModel validation;


        public RoadInvUnitTest()
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
        /// tests the county string list for valid coded values
        /// </summary>
        /// <param name="countyString">County coded value as a string. Non-zero padded</param>
        /// <param name="expectedResult">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
        [Theory]
        [InlineData("40", true)]
        [InlineData("75", true)]
        [InlineData("2", true)]
        [InlineData("4", true)]
        [InlineData("20", true)]
        [InlineData("90", false)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData("undefined", false)]
        public void CountyValues(string countyString, bool expectedResult)
        {

            //check if county 1 is in thing
            //validation.AH_County;
            var exists = false;
            foreach (var county in validation.AH_County)
            {
                
                if (county.CountyNumber == countyString)
                {
                    exists = true;
                }
                
            }
            if (expectedResult)
            {
                Assert.True(exists, "Missing county value for validations: " + countyString);
            } else
            {
                Assert.False(exists, "invalid value is in list " + countyString);
            }
            
            
        }

        /// <summary>
        /// Tests the district string list for valid values
        /// </summary>
        /// <param name="districtString">ArDOT Districts as string. Non-zero padded</param>
        /// <param name="expectedResult">Boolean value. True is the result is expected to return no errors. false is the expected result includes errors</param>
        [Theory]
        [InlineData("1", true)]
        [InlineData("7", true)]
        [InlineData("14", false)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData("undefined", false)]
        [InlineData("99", false)]
        public void DistrictValue(string districtString, bool expectedResult)
        {
            var exists = false;
            foreach(var district in validation.AH_District)
            {
                if (district.DistrictNumber == districtString)
                {
                    exists = true;
                }
            }

            if (expectedResult)
            {
                Assert.True(exists, "was expected to be allowed but its not");
            } 
            else
            {
                Assert.False(exists, "Value was expected to not be allowed but it passed through");
            }

        }

        /// <summary>
        /// Tests the route sign string list for expected values
        /// </summary>
        /// <param name="routeSignString">Route Sign coded value as a string (non-zero padded)</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("8", false)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData("undefined", false)]
        public void RouteSign(string routeSignString, bool expected)
        {
            var exists = false;
            foreach(var routeSign in validation.RouteSign)
            {
                if (routeSign.Domainvalue == routeSignString)
                {
                    exists = true;
                }
            }

            if (expected)
            {
                Assert.True(exists, "Value " + routeSignString + " was expected to be valid but its not. ");
            } else
            {
                Assert.False(exists, "Value " + routeSignString + " was expected to be valid but its not");
            }

        }

        /// <summary>
        /// Tests the Urban Code string list for expected coded values
        /// </summary>
        /// <param name="urbanCodeString">Urban Code coded value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
        [Theory]
        [InlineData("50392", true)]
        [InlineData("99999", false)]
        [InlineData("1", false)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData("undefined", false)]
        public void UrbanCode(string urbanCodeString, bool expected)
        {
            var exists = false;
            foreach(var urbanCode in validation.UrbanAreaCode)
            {
                if (urbanCode.UrbanCode == urbanCodeString)
                {
                    exists =  true;
                }
            }


            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// Tests system Status coded values string list
        /// </summary>
        /// <param name="StatusString">Status string as </param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("6", false)]
        [InlineData(" ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("undefined", false)]
        public void SystemStatus(string StatusString, bool expected)
        {
            var exists = false;
            foreach(var status in validation.SystemStatus)
            {
                if (StatusString == status.Domainvalue)
                {
                    exists = true;
                }
            }

            if (expected)
            {
                Assert.True(exists);
            }
             else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// Tests the functional class field for various coded value options
        /// </summary>
        /// <param name="funcString">Functional Class code as a string</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        [InlineData("6", true)]
        [InlineData("7", true)]
        [InlineData("17", false)]
        [InlineData("555", false)]
        [InlineData(" ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("undefined", false)]
        public void FuncClass(string funcString, bool expected)
        {
            var exists = false;
            foreach(var func in validation.FuncClass)
            {
                if (func.Domainvalue == funcString)
                {
                    exists = true;
                }
            }

            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// tests the direction coded values list for expected values
        /// </summary>
        /// <param name="directionString">Log Direction coded value as a string</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
        [Theory]
        [InlineData("A", true)]
        [InlineData("B", true)]
        [InlineData("X", false)]
        [InlineData("z", false)]
        [InlineData("Z", false)]
        [InlineData("12B", false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        [InlineData("undefined", false)]
        public void Direction(string directionString, bool expected)
        {
            var exists = false;
            foreach(var direction in validation.LOG_DIRECT)
            {
                if (direction.Domainvalue == directionString)
                {
                    exists = true;
                }
            }

            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// Tests access string list for expected coded values
        /// </summary>
        /// <param name="accessString">Access field coded value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("45", false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        [InlineData("undefined", false)]
        public void Access(string accessString, bool expected)
        {
            var exists = false;
            foreach(var access in validation.Access)
            {
                if (access.Domainvalue == accessString)
                {
                    exists = true;
                }
            }

            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// Tests Extra Lanes feild for expected coded values.
        /// </summary>
        /// <param name="extraLanesString">Extra Lanes coded value as string</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
        [Theory]
        [InlineData("0", true)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        [InlineData("6", true)]
        [InlineData("7", true)]
        [InlineData("12", false)]
        [InlineData("44", false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        [InlineData("undefined", false)]
        public void ExtraLanes(string extraLanesString, bool expected)
        {
            var exists = false;
            foreach(var extraLanes in validation.ExtraLanes)
            {
                if (extraLanes.Domainvalue == extraLanesString)
                {
                    exists = true;
                }
            }
            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// Tests APHN Field for expected coded values
        /// </summary>
        /// <param name="APHNString">APHN coded value as string</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
        [Theory]
        [InlineData("0", true)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("7", false)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        [InlineData("undefined", false)]
        [InlineData("", false)]
        public void APHN(string APHNString, bool expected)
        {
            var exists = false;
            foreach(var APHN in validation.APHN)
            {
                if (APHN.Domainvalue == APHNString)
                {
                    exists = true;
                }
            }
            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// Tests NHS string list for expected coded values
        /// </summary>
        /// <param name="NHSString">NHS coded value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
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
        [InlineData("02", false)]
        [InlineData("17", false)]
        [InlineData(" ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("undefined", false)]
        public void NHS(string NHSString, bool expected)
        {
            var exists = false;
            foreach(var NHS in validation.NHS)
            {
                if (NHS.Domainvalue == NHSString)
                {
                    exists = true;
                }
            }
            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// Tests Special Systems string list for expected coded values
        /// </summary>
        /// <param name="SpecialSystemsString">Special Systems coded value as a string</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
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
        [InlineData("19", false)]
        [InlineData(" ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("undefined", false)]
        public void SpecialSystems(string SpecialSystemsString, bool expected)
        {
            var exists = false;
            foreach(var special in validation.SpecialSystems)
            {
                if (special.Domainvalue == SpecialSystemsString)
                {
                    exists = true;
                }
            }

            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// Tests shoulder surface string list for expected values
        /// </summary>
        /// <param name="shoulderSurfaceString">Shoulder Surface coded value as string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
        [Theory]
        [InlineData("0", true)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        [InlineData("6", true)]
        [InlineData("50", false)]
        [InlineData("-5", false)]
        [InlineData("56", false)]
        [InlineData("12", false)]
        [InlineData(" ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("undefined", false)]
        public void ShoulderSurface(string shoulderSurfaceString, bool expected)
        {
            var exists = false;
            foreach(var surface in validation.ShoulderSurface)
            {
                if (surface.Domainvalue == shoulderSurfaceString)
                {
                    exists = true;
                }
            }

            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// Tests goverment code string list for expected values
        /// </summary>
        /// <param name="GovermentCodeString">Goveremnt Code coded value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
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
        [InlineData("12", false)]
        [InlineData("13", false)]
        [InlineData("14", false)]
        [InlineData("70", true)]
        [InlineData(" ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("undefined", false)]
        public void GovermentCode(string GovermentCodeString, bool expected)
        {
            var exists = false;
            foreach(var code in validation.GovermentCode)
            {
                if (code.Domainvalue == GovermentCodeString)
                {
                    exists = true;
                }
            }

            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// Tests surface type string object for expected values
        /// </summary>
        /// <param name="SurfaceTypeString">Surface Type coded value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
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
        [InlineData("9", true)]
        [InlineData("10", true)]
        [InlineData(" ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("undefined", false)]
        public void SurfaceType (string SurfaceTypeString, bool expected)
        {
            var exists = false;
            foreach(var surface in validation.SurfaceType)
            {
                if (surface.Domainvalue == SurfaceTypeString)
                {
                    exists = true;
                }
            }

            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// Tests type operation string list for expected coded-values
        /// </summary>
        /// <param name="typeOperationString">Type Operation coded value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
        [Theory]
        [InlineData("0", false)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData(" ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("undefined", false)]
        public void TypeOperation(string typeOperationString, bool expected)
        {
            var exists = false;
            foreach(var typeOperation in validation.TypeOperation)
            {
                if (typeOperation.Domainvalue == typeOperationString)
                {
                    exists = true;
                }
            }

            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// Tests Type Road string list for expected coded values
        /// </summary>
        /// <param name="typeRoadString">Type Road coded value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
        [Theory]
        [InlineData("0", false)]
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
        [InlineData(" ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("undefined", false)]
        public void RoadType(string typeRoadString, bool expected)
        {
            var exists = false;
            foreach(var typeRoad in validation.TypeRoad)
            {
                if (typeRoad.Domainvalue == typeRoadString)
                {
                    exists = true;
                }
            }

            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// Tests median type string list for expected values
        /// </summary>
        /// <param name="medianTypeString">Median Type Coded value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
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
        [InlineData("9", false)]
        [InlineData("10", false)]
        [InlineData("11", false)]
        [InlineData("12", false)]
        [InlineData("13", false)]
        [InlineData(" ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("undefined", false)]
        public void MedianType(string medianTypeString, bool expected)
        {
            var exists = false;
            foreach(var medianType in validation.MedianType)
            {
                if (medianType.Domainvalue == medianTypeString)
                {
                    exists = true;
                }
            }

            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// Tests Both District and county fields for valid combinations of the two fields. 
        /// District only cover certain districts. Not all combinations are valid.
        /// Invalid combinations should cause data validation errors.
        /// </summary>
        /// <param name="county">ArDOT County number as a non-zero padded string object</param>
        /// <param name="district">ArDOT District number as a non-zero padded string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
        [Theory]
        [InlineData("60", "6", true)]//pulaski county and district 6
        [InlineData("60", "1", false)]
        [InlineData("60", "2", false)]
        [InlineData("60", "3", false)]
        [InlineData("60", "4", false)]
        [InlineData("60", "5", false)]
        public void CountyDistrictPair(string county, string district, bool expected)
        {
            var exists = false;
            foreach(var pair in validation.PairCountyDistrict)
            {
                if (pair.CountyNumber == county & pair.DistrictNumber == district)
                {
                    exists = true;
                }
            }

            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// Tests Urban Area field as for expected coded values
        /// </summary>
        /// <param name="urbanArea">Urban Area coded value as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
        [Theory]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("0", false)]
        [InlineData("8", false)]
        [InlineData(" ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("undefined", false)]
        public void UrbanArea(string urbanArea, bool expected)
        {
            var exists = false;
            foreach(var urban in validation.RuralUrbanArea)
            {
                if (urban.Domainvalue == urbanArea)
                {
                    exists = true;
                }
            }
            if (expected)
            {
                Assert.True(exists);
            } else 
            {
                Assert.False(exists);    
            }
        }

        /// <summary>
        /// Tests section code string list for expected values
        /// </summary>
        /// <param name="codeString">Section Code letter as a string object</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
        [Theory]
        [InlineData("A", true)]
        [InlineData("B", true)]
        [InlineData("C", true)]
        [InlineData("E", true)]
        [InlineData("N", true)]
        [InlineData("P", true)]
        [InlineData("S", true)]
        [InlineData("L", true)]
        [InlineData("Y", true)]
        [InlineData("W", true)]
        [InlineData("T", true)]
        [InlineData("1", false)]
        [InlineData("2", false)]
        [InlineData("3", false)]
        [InlineData("4", false)]
        [InlineData("0", false)]
        [InlineData("8", false)]
        [InlineData(" ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("undefined", false)]
        public void SectionCode(string codeString, bool expected)
        {
            var exists = false;
            foreach(var code in validation.SectionCode)
            {
                if (code.SectionCode == codeString)
                {
                    exists = true;
                }
            }

            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
        }

        /// <summary>
        /// Tests Urban Area Code and county field value combinations. specific urban areas only exist in certain counties. 
        /// For instance the little rock urbanizated area can't exist in washington county. 
        /// These should cause validation errors to be flagged.
        /// </summary>
        /// <param name="urbanAreaCode">Urban Area Code as string object</param>
        /// <param name="county">ArDOT County code as a non-zero padded string</param>
        /// <param name="expected">Boolean value. True is the result is expected to return no validation errors. 
        /// false is the expected result includes errors</param>
        [Theory]
        [InlineData("40213", "26", true)]
        [InlineData("40213", "70", false)]
        [InlineData("69454", "35", true)]
        [InlineData("69454", "2", false)]
        public void UrbanAreaCodeCountyPair(string urbanAreaCode, string county, bool expected)
        {
            var exists = false;
            foreach(var pair in validation.PairUrbanAreaCounty)
            {
                if (pair.CountyNumber == county & pair.UrbanCode == urbanAreaCode)
                {
                    exists = true;
                }
            }

            if (expected)
            {
                Assert.True(exists);
            } else
            {
                Assert.False(exists);
            }
            
        }

        /// <summary>
        /// Tests the CheckInvaidCharacters method on the ValidationModel Class. 
        /// The CheckInvalidCharacters method is used by validation logic tied 
        /// to the route, and section fields. testing of this method elimiates a 
        /// single cause when debugging other method's dependent on 
        /// CheckInvalidCharacters.
        /// </summary>
        /// <param name="testString"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData("104", true)]
        [InlineData("14", true)]
        [InlineData("YELLOW45", true)]
        [InlineData("##", false)]
        [InlineData("55", true)]
        [InlineData("0", true)]
        public void ValidCharacters(string testString, bool expected)
        {
            var invalidChars = ValidationModel.checkInvalidCharacters(testString);

            if (expected)
            {
                Assert.True(invalidChars.Count == 0);
            } else
            {
                Assert.False(invalidChars.Count == 0);
            }
        }

    }
}
