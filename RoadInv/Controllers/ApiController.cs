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
        public roadinvContext _dbContext;
        public BulkEditModel _bulkEdits;

        public ApiController(roadinvContext dbContext)
        {
            _dbContext = dbContext;
            _bulkEdits = new BulkEditModel(this._dbContext);
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
            var segment = this._dbContext.RoadInvs.Find(ID);

            this._dbContext.RoadInvs.Remove(segment);
            this._dbContext.SaveChanges();
            //one if successfull, zero if unsuccessfull
            return Json(1);
        }

        [Route("api/dup_segement")]
        [Route("api/dup_segement.html")]
        public IActionResult DuplicateSegment(int ID, string AH_County = "",
            string AH_Route = "",
            string AH_Section = "",
            string LOG_DIRECT = "",
            decimal AH_BLM = -1,
            decimal AH_ELM = -1)
        {
            var segmentDetails = this._dbContext.RoadInvs.Find(ID);

            //clone and set values for new clone
            var duplicate = new DB.RoadInv();

            //customize attributes of duplicate
            if (AH_BLM != -1)
            {
                duplicate.AhBlm = AH_BLM;
            }
            
            if (segmentDetails.AhCounty != "")
            {
                duplicate.AhCounty = AH_County;
            }

            
            if (AH_ELM != -1)
            {
                duplicate.AhElm = AH_ELM;
            }

            if (AH_Route != "")
            {
                duplicate.AhRoute = AH_Route;
            }

            if (AH_Section != "")
            {
                duplicate.AhSection = AH_Section;
            }

            if (LOG_DIRECT != "")
            {
                duplicate.LogDirect = LOG_DIRECT;
            }

            //explicitly set every single attribute
            duplicate.Access = segmentDetails.Access;
            duplicate.AhDistrict = segmentDetails.AhDistrict;
            duplicate.AlternativeRouteName = segmentDetails.AlternativeRouteName;
            duplicate.Aphn = segmentDetails.Aphn;
            duplicate.ArnoldConv = segmentDetails.ArnoldConv;
            duplicate.BothDirectionNumLanes = segmentDetails.BothDirectionNumLanes;
            duplicate.Comment1 = segmentDetails.Comment1;
            duplicate.ExtraLanes = segmentDetails.ExtraLanes;
            duplicate.FuncClass = segmentDetails.FuncClass;
            duplicate.GovermentCode = segmentDetails.GovermentCode;
            duplicate.LaneWidth = segmentDetails.LaneWidth;
            duplicate.LeftShoulderSurface = segmentDetails.LeftShoulderSurface;
            duplicate.LeftShoulderWidth = segmentDetails.LeftShoulderWidth;
            duplicate.MedianType = segmentDetails.MedianType;
            duplicate.MedianWidth = segmentDetails.MedianWidth;
            duplicate.Nhs = segmentDetails.Nhs;
            duplicate.OneDirectionNumLanes = segmentDetails.OneDirectionNumLanes;
            duplicate.RightShoulderSurface = segmentDetails.RightShoulderSurface;
            duplicate.RightShoulderWidth = segmentDetails.RightShoulderWidth;
            duplicate.RoadwayWidth = segmentDetails.RoadwayWidth;
            duplicate.RouteSign = segmentDetails.RouteSign;
            duplicate.RuralUrbanArea = segmentDetails.RuralUrbanArea;
            duplicate.SpecialSystems = segmentDetails.SpecialSystems;
            duplicate.SurfaceType = segmentDetails.SurfaceType;
            duplicate.SurfaceWidth = segmentDetails.SurfaceWidth;
            duplicate.SystemStatus = segmentDetails.SystemStatus;
            duplicate.TypeOperation = segmentDetails.TypeOperation;
            duplicate.TypeRoad = segmentDetails.TypeRoad;
            duplicate.UrbanAreaCode = segmentDetails.UrbanAreaCode;
            duplicate.YearBuilt = segmentDetails.YearBuilt;
            duplicate.YearRecon = segmentDetails.YearRecon;

            this._dbContext.RoadInvs.Add(duplicate);
            this._dbContext.SaveChanges();

            int newID = duplicate.Id;

            return Json(newID);
        }

        [Route("api/new_segement")]
        public IActionResult SaveNew(string AH_District = "",
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
            int LaneWidth = 0,
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

            var segment = new DB.RoadInv();
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
            segment.LaneWidth = LaneWidth;
            segment.MedianWidth = MedianWidth;
            segment.SurfaceWidth = SurfaceWidth;
            segment.RightShoulderSurface = RightShoulderSurface;
            segment.LeftShoulderSurface = LeftShoulderSurface;
            segment.RightShoulderWidth = RightShoulderWidth;
            segment.LeftShoulderWidth = LeftShoulderWidth;
            segment.RoadwayWidth = RoadwayWidth;
            segment.ExtraLanes = ExtraLanes;
            segment.MedianType = MedianType;
            segment.SurfaceType = SurfaceType;
            segment.AlternativeRouteName = Alternative_Route_Name;
            segment.AhBlm = AH_BLM;
            segment.AhElm = AH_ELM;

            this._dbContext.RoadInvs.Add(segment);
            this._dbContext.SaveChanges();

            int newID = segment.Id;

            //one if successfull, zero if unsuccessfull
            return Json(newID);
        }

        [Route("api/mirror_segement")]
        public IActionResult MirrorSegment(int ID, string AH_County = "",
            string AH_Route = "",
            string AH_Section = "",
            string LOG_DIRECT = "",
            decimal AH_BLM = -1,
            decimal AH_ELM = -1)
        {
            var segmentDetails = this._dbContext.RoadInvs.Find(ID);
            var duplicate = ErrorItemBulkModel.CloneSegment(segmentDetails);

            //attributes that need to be mirrored to antilog side
            if (int.TryParse(segmentDetails.BothDirectionNumLanes, out _) & int.TryParse(segmentDetails.OneDirectionNumLanes, out _))
            {
                duplicate.OneDirectionNumLanes = (int.Parse(segmentDetails.BothDirectionNumLanes) - int.Parse(segmentDetails.OneDirectionNumLanes)).ToString();
            }
            
            duplicate.LeftShoulderSurface = segmentDetails.RightShoulderSurface;
            duplicate.LeftShoulderWidth = segmentDetails.RightShoulderWidth;
            duplicate.RightShoulderSurface = segmentDetails.LeftShoulderSurface;
            duplicate.RightShoulderWidth = segmentDetails.LeftShoulderWidth;

            this._dbContext.RoadInvs.Add(duplicate);
            this._dbContext.SaveChanges();

            int newID = duplicate.Id;

            return Json(newID);
        }

        [Route("api/validate_bulk")]
        public IActionResult ValidateBulk(string AH_RoadID, decimal AH_BLM, decimal AH_ELM, string NHS)
        {
            var overlappingRecords = from record in this._dbContext.RoadInvs
                         where record.AhRoadId == AH_RoadID & (record.AhBlm < AH_BLM &  record.AhElm > AH_BLM) | (record.AhBlm < AH_ELM & record.AhElm > AH_ELM)
                         select record;

            foreach(var row in overlappingRecords)
            {
                row.Nhs = NHS;
            }


            var bulkErrors = new ErrorItemBulkModel(this._dbContext, AH_BLM, AH_ELM, overlappingRecords);

            //find all associated records
            //summarize findings by the following factors
            // - number of records effected
            // - number of records error
            // - miles of records effected
            // - miles of records error
            // - find number of out of range miles

            var bulkErrorsErrors = Json(bulkErrors);

            return bulkErrorsErrors;
        }

        [Route("api/edit_bulk/nhs")]
        public IActionResult ImplimentBulkEdit(string AH_RoadID, decimal AH_BLM, decimal AH_ELM, string NHS)
        {
            //split records that partly overlap the designation into multiple pieces
            var ajustedSegments  = _bulkEdits.BulkEdit(AH_RoadID, AH_BLM, AH_ELM);

            foreach(var row in ajustedSegments)
            {
                row.Nhs = NHS;
            }
            _bulkEdits._dbContext.SaveChanges();

            return null;
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
