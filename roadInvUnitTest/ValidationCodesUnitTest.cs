using System;
using Xunit;
using RoadInv.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace roadInvUnitTest
{
    public class RoadInvUnitTest
    {
        public RoadInv.DB.roadinvContext _dbContext;
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

        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.test.json")
                .Build();
            return config;
        }


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
        public void countyValues(string countyString, bool expectedResult)
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

        [Theory]
        [InlineData("1", true)]
        [InlineData("7", true)]
        [InlineData("14", false)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData("undefined", false)]
        public void districtValue(string districtString, bool expectedResult)
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

        [Theory]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("8", false)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData("undefined", false)]
        public void routeSign(string routeSignString, bool expected)
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

        [Theory]
        [InlineData("50392", true)]
        [InlineData("99999", false)]
        [InlineData("1", false)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData("undefined", false)]
        public void urbanCode(string urbanCodeString, bool expected)
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
        public void direction(string directionString, bool expected)
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

        [Theory]
        [InlineData("104", true)]
        [InlineData("14", true)]
        [InlineData("YELLOW45", true)]
        [InlineData("##", false)]
        [InlineData("55", true)]
        [InlineData("0", true)]
        public void validCharacters(string testString, bool expected)
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
