﻿using Microsoft.AspNetCore.Mvc;
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
        public roadinvContext _dbContext;

        public ApiController(roadinvContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult test(int ID)
        {
            var segment = this._dbContext.RoadInvs.Find(ID);


            return Json(0);
        }


        [Route("api/update")]
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

            var segment = this._dbContext.RoadInvs.Find(ID);
            segment.Id = ID;
            segment.AhDistrict = AH_District;
            segment.AhCounty = AH_County;
            segment.AhRoute = AH_Route;
            segment.AhSection = AH_Section;
            segment.LogDirect = LOG_DIRECT;
            segment.GovermentCode = GovermentCode;
            segment.RuralUrbanArea = RuralUrbanArea;
            segment.UrbanAreaCode = UrbanAreaCode;
            segment.FuncClass = FuncClass;
            segment.Nhs = NHS;
            segment.SystemStatus = SystemStatus;
            segment.SpecialSystems = SpecialSystems;
            segment.BothDirectionNumLanes = BothDirectionNumLanes;
            segment.OneDirectionNumLanes = OneDirectionNumLanes;
            segment.Comment1 = Comment1;
            segment.TypeRoad = TypeRoad;
            segment.RouteSign = RouteSign;
            segment.Aphn = APHN;
            segment.Access = Access;
            segment.TypeOperation = TypeOperation;
            segment.YearBuilt = YearBuilt;
            segment.YearRecon = yearRecon;
            segment.MedianWidth = MedianWidth;
            segment.SurfaceWidth = SurfaceWidth;
            segment.RightShoulderSurface = RightShoulderSurface;
            segment.LeftShoulderSurface = LeftShoulderSurface;
            segment.RoadwayWidth = RoadwayWidth;
            segment.ExtraLanes = ExtraLanes;
            segment.MedianType = MedianType;
            segment.SurfaceType = SurfaceType;
            segment.AlternativeRouteName = Alternative_Route_Name;
            segment.AhBlm = AH_BLM;
            segment.AhElm = AH_ELM;

            ValidationModel.CleanAttr(segment);
            

            int newRecordCount = this._dbContext.SaveChanges();

            //submit new database for 

            return Json(newRecordCount);
        }


        [Route("api/delete")]
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


        [Route("api/validate")]
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

            DB.RoadInv segment = new DB.RoadInv();
            segment.AhDistrict = AH_District;
            segment.AhCounty = AH_County;
            segment.AhRoute = AH_Route;
            segment.AhSection = AH_Section;
            segment.LogDirect = LOG_DIRECT;
            segment.GovermentCode = GovermentCode;
            segment.RuralUrbanArea = RuralUrbanArea;
            segment.UrbanAreaCode = UrbanAreaCode;
            segment.FuncClass = FuncClass;
            segment.Nhs = NHS;
            segment.SystemStatus = SystemStatus;
            segment.SpecialSystems = SpecialSystems;
            segment.BothDirectionNumLanes = BothDirectionNumLanes;
            segment.OneDirectionNumLanes = OneDirectionNumLanes;
            segment.Comment1 = Comment1;
            segment.TypeRoad = TypeRoad;
            segment.RouteSign = RouteSign;
            segment.Aphn = APHN;
            segment.Access = Access;
            segment.TypeOperation = TypeOperation;
            segment.YearBuilt = YearBuilt;
            segment.YearRecon = yearRecon;
            segment.MedianWidth = MedianWidth;
            segment.SurfaceWidth = SurfaceWidth;
            segment.RightShoulderSurface = RightShoulderSurface;
            segment.LeftShoulderSurface = LeftShoulderSurface;
            segment.RoadwayWidth = RoadwayWidth;
            segment.ExtraLanes = ExtraLanes;
            segment.MedianType = MedianType;
            segment.SurfaceType = SurfaceType;
            segment.AlternativeRouteName = Alternative_Route_Name;
            segment.AhBlm = AH_BLM;
            segment.AhElm = AH_ELM;

            ValidationModel.CleanAttr(segment);
            var val = new ValidationModel(_dbContext);
            var errorList = val.FindErrors(segment);

            return Json(errorList);
        }
    }
}
