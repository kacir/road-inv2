using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using RoadInv.Models;
using RoadInv.DB;
using Z.EntityFramework.Plus;
using Microsoft.AspNetCore.Authorization;

namespace RoadInv.Controllers
{

    [Authorize("admin-only")]
    public class HomeController : Controller
    {
        private roadinvContext _dbContext;
        public HomeController(roadinvContext dbContext)
        {
            this._dbContext = dbContext;
        }


        [Route("error.html")]
        [Route("error")]
        public IActionResult error()
        {
            return View("error");
        }

        
        [Route("segments.html")]
        [Route("segments")]
        public IActionResult SearchTable(string district= "", string county = "", string route = "", string section = "", string direction = "", decimal logmile = -1, string typeroad = "")
        {
            //clean attributes to make the query more likely to success if there is a typo of some kind
            if (district is not null)
            {
                district = district.Trim();
            }
            if (county is not null)
            {
                county = county.Trim();
            }
            if (route is not null)
            {
                route = route.Trim();
            }
            if (section is not null)
            {
                section = section.Trim();
            }
            if (direction is not null)
            {
                direction = direction.Trim();
            }
            if (typeroad is not null)
            {
                typeroad = typeroad.Trim();
            }

            IQueryable<DB.RoadInv> output;

            output = from record in this._dbContext.RoadInvs where 
                          (record.AhDistrict == district | district == "" | district == null) & 
                          (record.AhCounty == county | county == "" | county == null) & 
                          (record.AhRoute == route | route == "" | route == null) &
                          (record.AhSection == section | section == "" | section == null) &
                          (record.LogDirect == direction | direction == "" | direction == null) &
                          ((record.AhBlm <= logmile & record.AhElm >= logmile) | logmile == -1) &
                          (record.TypeRoad == typeroad | typeroad == "" | typeroad == null)
                          orderby record.RouteSign ascending, record.AhRoadId ascending, record.AhBlm ascending 
                          select record;

            output = output.Take(1000);


            var val = new ValidationModel(_dbContext);
            var pageModel = new SearchPageModel(val, details: output);

            pageModel.filterCounty = county;
            pageModel.filterRoute = route;
            pageModel.filterSection = section;
            pageModel.filterDirection = direction;
            pageModel.filterDistrict = district;
            pageModel.filterLogmile = logmile;
            pageModel.filterTypeRoad = typeroad;


            return View("SearchTable", pageModel);
        }
        
        [Route("/")]
        [Route("/index")]
        [Route("/index.html")]
        public IActionResult Index()
        {
            return View("index");
        }

        [Route("new_Segment.html")]
        [Route("new_Segment")]
        public IActionResult new_segment()
        {
            var segmentDetails = new DB.RoadInv();
            segmentDetails.Id = -1;
            var val = new ValidationModel(this._dbContext);

            var SegmentPageObj = new SegmentDetailPageModel(segmentDetails, val, SegmentDetailPageModel.newSegment);

            return View("edit_Segment", SegmentPageObj);
        }

        [Route("dup_Segment")]
        [Route("dup_Segment.html")]
        public IActionResult DuplicateSegment(int ID)
        {
            
            var segmentDetails = this._dbContext.RoadInvs.Find(ID);
            segmentDetails.Id = -1;
            var val = new ValidationModel(this._dbContext);

            var SegmentPageObj = new SegmentDetailPageModel(segmentDetails, val, SegmentDetailPageModel.duplicateSegment);

            return View("edit_Segment", SegmentPageObj);
        }

        [Route("edit_Segment")]
        [Route("edit_Segment.html")]
        public IActionResult edit_Segment(int ID = -1)
        {
            var segmentDetails = this._dbContext.RoadInvs.Find(ID);
            var val = new ValidationModel(this._dbContext);
            var SegmentPageObj = new SegmentDetailPageModel(segmentDetails, val, SegmentDetailPageModel.editSegment);

            return View("edit_Segment", SegmentPageObj);
        }

        [Route("quality_control")]
        [Route("quality_control.html")]
        public IActionResult quality_control()
        {           
            return View("quality_control", _dbContext);
        }

        [Route("bulk_validate")]
        [Route("bulk_validate.html")]
        public IActionResult BulkValidateAll()
        {
            var validator = new BulkValidationModel(this._dbContext);
            validator.BulkValidate();

            return View("bulk_validate", validator.masterList);
        }

    }
}
