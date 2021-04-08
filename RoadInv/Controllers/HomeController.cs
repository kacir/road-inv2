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

namespace RoadInv.Controllers
{

    public class HomeController : Controller
    {
        private roadinvContext _dbContext;
        public HomeController(roadinvContext dbContext)
        {
            this._dbContext = dbContext;
        }


        public IActionResult error()
        {
            return View("error");
        }


        public IActionResult SearchTable(string district= "", string county = "", string route = "", string section = "", string direction = "", decimal logmile = -1)
        {
            IQueryable<DB.RoadInv> output;

            output = this._dbContext.RoadInvs.Where(b => (b.AhDistrict == district | district == "") &
                (b.AhCounty == county | county == "") &
                (b.AhRoute == route | route == "") &
                (b.LogDirect == direction | direction == "") &
                ((b.AhBlm >= logmile & b.AhElm <= logmile) | logmile == -1));

            output = output.OrderBy(x => x.RouteSign)
                .ThenBy(x => x.AhRoadId)
                .ThenBy(x => x.AhBlm)
                .Take(1000);


            var val = new ValidationModel(_dbContext);
            var pageModel = new SearchPageModel(val, details: output);

            ViewBag.county = county;
            ViewBag.route = route;
            ViewBag.section = section;
            ViewBag.direction = direction;
            ViewBag.district = district;
            ViewBag.logmile = logmile;


            return View("SearchTable", pageModel);
        }
        
        public IActionResult Index()
        {
            return View("index");
        }

        public IActionResult new_segment()
        {
            var segmentDetails = new DB.RoadInv();
            segmentDetails.Id = -1;
            var val = new ValidationModel(this._dbContext);

            var segementPageObj = new SegementDetailPageModel(segmentDetails, val, SegementDetailPageModel.newSegment);

            return View("edit_segement", segementPageObj);
        }


        public IActionResult DuplicateSegment(int ID)
        {
            
            var segmentDetails = this._dbContext.RoadInvs.Find(ID);
            segmentDetails.Id = -1;
            var val = new ValidationModel(this._dbContext);

            var segementPageObj = new SegementDetailPageModel(segmentDetails, val, SegementDetailPageModel.duplicateSegment);

            return View("edit_segement", segementPageObj);
        }


        public IActionResult MirrorSegment(int ID)
        {
            var segmentDetails = this._dbContext.RoadInvs.Find(ID);
            segmentDetails.Id = -1;
            var val = new ValidationModel(this._dbContext);

            var segementPageObj = new SegementDetailPageModel(segmentDetails, val, SegementDetailPageModel.duplicateSegment);

            return View("edit_segement", segementPageObj);
        }


        public IActionResult edit_segement(int ID = -1)
        {
            var segmentDetails = this._dbContext.RoadInvs.Find(ID);
            var val = new ValidationModel(this._dbContext);
            var segementPageObj = new SegementDetailPageModel(segmentDetails, val, SegementDetailPageModel.editSegment);

            return View("edit_segement", segementPageObj);
        }


        public IActionResult quality_control()
        {           
            return View("quality_control", _dbContext);
        }

    }
}
