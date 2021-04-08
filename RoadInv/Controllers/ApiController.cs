using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RoadInv.DB;
using RoadInv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace RoadInv.Controllers
{
    
    public class ApiController : Controller
    {
        public SearchDatabaseModel _search;
        public roadinvContext _dbContext;

        public ApiController(SearchDatabaseModel search, roadinvContext dbContext)
        {
            _search = search;
            _dbContext = dbContext;
        }


        
        public IActionResult Update(int ID,
            string AH_District = "",
            string AH_County = "",
            string AH_Route = "",
            string AH_Section = "",
            string LOG_DIRECT = "",
            string GovermentCode = "",
            string RuralUrbanArea = "",
            string UrbanAreaCode = "",
            string FuncClass = "",
            string NHS = "",
            string SystemStatus = "",
            string SpecialSystems = "",
            string BothDirectionNumLanes = "",
            string OneDirectionNumLanes = "",
            string Comment1 = "",
            string TypeRoad = "",
            string RouteSign = "",
            string APHN = "",
            string Access = "",
            string TypeOperation = "",
            string YearBuilt = "",
            string yearRecon = "",
            string MedianWidth = "",
            string LaneWidth = "",
            int SurfaceWidth = 0,
            string RightShoulderSurface = "",
            string LeftShoulderSurface = "",
            int RightShoulderWidth = -1,
            int LeftShoulderWidth = -1,
            int RoadwayWidth = 999,
            string ExtraLanes = "",
            string MedianType = "",
            string SurfaceType = "",
            string Alternative_Route_Name = "",
            decimal AH_BLM = 0,
            decimal AH_ELM = 0)
        {

            SegmentModel segment = new SegmentModel();
            segment.ID = ID;
            segment.AH_District = AH_District;
            segment.AH_County = AH_County;
            segment.AH_Route = AH_Route;
            segment.AH_Section = AH_Section;
            segment.LOG_DIRECT = LOG_DIRECT;
            segment.GovermentCode = GovermentCode;
            segment.RuralUrbanArea = RuralUrbanArea;
            segment.UrbanAreaCode = UrbanAreaCode;
            segment.FuncClass = FuncClass;
            segment.NHS = NHS;
            segment.SystemStatus = SystemStatus;
            segment.SpecialSystems = SpecialSystems;
            segment.BothDirectionNumLanes = BothDirectionNumLanes;
            segment.OneDirectionNumLanes = OneDirectionNumLanes;
            segment.Comment1 = Comment1;
            segment.TypeRoad = TypeRoad;
            segment.RouteSign = RouteSign;
            segment.APHN = APHN;
            segment.Access = Access;
            segment.TypeOperation = TypeOperation;
            segment.YearBuilt = YearBuilt;
            segment.yearRecon = yearRecon;
            segment.MedianWidth = MedianWidth;
            segment.SurfaceWidth = SurfaceWidth;
            segment.RightShoulderSurface = RightShoulderSurface;
            segment.LeftShoulderSurface = LeftShoulderSurface;
            segment.RoadwayWidth = RoadwayWidth;
            segment.ExtraLanes = ExtraLanes;
            segment.MedianType = MedianType;
            segment.SurfaceType = SurfaceType;
            segment.Alternative_Route_Name = Alternative_Route_Name;
            segment.AH_BLM = AH_BLM;
            segment.AH_ELM = AH_ELM;

            segment.CleanAttr();//clean white space and get everything in uppercase

            int newRecordCount = this._search.NewRecord(segment);

            //submit new database for 

            return Json(newRecordCount);
        }


        
        public IActionResult Delete(int ID)
        {
            //one if successfull, zero if unsuccessfull
            return Json(0);
        }

        public IActionResult SaveNew(int ID)
        {
            //one if successfull, zero if unsuccessfull
            return Json(0);
        }


        
        public IActionResult Validate(string AH_District = "",
            string AH_County = "",
            string AH_Route = "",
            string AH_Section = "",
            string LOG_DIRECT = "",
            string GovermentCode = "",
            string RuralUrbanArea = "",
            string UrbanAreaCode = "",
            string FuncClass = "",
            string NHS = "",
            string SystemStatus = "",
            string SpecialSystems = "",
            string BothDirectionNumLanes = "",
            string OneDirectionNumLanes = "",
            string Comment1 = "",
            string TypeRoad = "",
            string RouteSign = "",
            string APHN = "",
            string Access = "",
            string TypeOperation = "",
            string YearBuilt = "",
            string yearRecon = "",
            string MedianWidth = "",
            string LaneWidth = "",
            int SurfaceWidth = 0,
            string RightShoulderSurface = "",
            string LeftShoulderSurface = "",
            int RightShoulderWidth = -1,
            int LeftShoulderWidth = -1,
            int RoadwayWidth = 999,
            string ExtraLanes = "",
            string MedianType = "",
            string SurfaceType = "",
            string Alternative_Route_Name = "",
            decimal AH_BLM = 0,
            decimal AH_ELM = 0
            )
        {

            SegmentModel segment = new SegmentModel();
            segment.AH_District = AH_District;
            segment.AH_County = AH_County;
            segment.AH_Route = AH_Route;
            segment.AH_Section = AH_Section;
            segment.LOG_DIRECT = LOG_DIRECT;
            segment.GovermentCode = GovermentCode;
            segment.RuralUrbanArea = RuralUrbanArea;
            segment.UrbanAreaCode = UrbanAreaCode;
            segment.FuncClass = FuncClass;
            segment.NHS = NHS;
            segment.SystemStatus = SystemStatus;
            segment.SpecialSystems = SpecialSystems;
            segment.BothDirectionNumLanes = BothDirectionNumLanes;
            segment.OneDirectionNumLanes = OneDirectionNumLanes;
            segment.Comment1 = Comment1;
            segment.TypeRoad = TypeRoad;
            segment.RouteSign = RouteSign;
            segment.APHN = APHN;
            segment.Access = Access;
            segment.TypeOperation = TypeOperation;
            segment.YearBuilt = YearBuilt;
            segment.yearRecon = yearRecon;
            segment.MedianWidth = MedianWidth;
            segment.SurfaceWidth = SurfaceWidth;
            segment.RightShoulderSurface = RightShoulderSurface;
            segment.LeftShoulderSurface = LeftShoulderSurface;
            segment.RoadwayWidth = RoadwayWidth;
            segment.ExtraLanes = ExtraLanes;
            segment.MedianType = MedianType;
            segment.SurfaceType = SurfaceType;
            segment.Alternative_Route_Name = Alternative_Route_Name;
            segment.AH_BLM = AH_BLM;
            segment.AH_ELM = AH_ELM;

            segment.CleanAttr();//clean white space and get everything in uppercase
            var val = new ValidationModel(_dbContext);
            var errorList = val.FindErrors(segment);

            return Json(errorList);
        }
    }
}
