﻿using Microsoft.AspNetCore.Mvc;
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
        private SearchDatabaseModel _search;
        private roadinvContext _dbContext;
        public HomeController(SearchDatabaseModel search, roadinvContext dbContext)
        {
            this._search = search;
            this._dbContext = dbContext;
        }


        [Route("segments.html")]
        [Route("segments")]
        public IActionResult SearchTable(string district= "", string county = "", string route = "", string section = "", string direction = "", decimal logmile = -1)
        {
            List<SegmentModel> output;
            if (int.TryParse(county, out int county_num))
            {
                output = _search.search(district : district, county : county_num, route : route, section: section, direction : direction, logmile : logmile);
            }
            else
            {
                output = _search.search(district: district, county : 0, route : route, section : section, direction : direction, logmile: logmile);
            }

            ArrayList countyList = _search.CountyList();
            string[] blankArray = { "", "" };
            countyList.Insert(0, blankArray);//Blank option must be avaliable

            var val = new ValidationModel(_dbContext);
            var pageModel = new SearchPageModel(val, details: output);


            ViewBag.countyList = countyList;
            ViewBag.county = county;
            ViewBag.route = route;
            ViewBag.section = section;
            ViewBag.direction = direction;
            ViewBag.district = district;
            ViewBag.logmile = logmile;


            return View("SearchTable", pageModel);
        }
        
        [Route("/")]
        [Route("/index")]
        [Route("/index.html")]
        public IActionResult Index()
        {
            return View("index");
        }

        [Route("new_segement.html")]
        [Route("new_segement")]
        public IActionResult new_segment()
        {
            return View("new_segement");
        }

        [Route("edit_segement")]
        [Route("edit_segement.html")]
        public IActionResult edit_segement(int ID = -1)
        {
            var segmentDetails = this._search.segementDetails(ID);
            var val = new ValidationModel(this._dbContext);
            var segementPageObj = new SegementDetailPageModel(segmentDetails, val);

            return View("edit_segement", segementPageObj);
        }

        [Route("quality_control")]
        [Route("quality_control.html")]
        public IActionResult quality_control()
        {           
            return View("quality_control", _dbContext);
        }

    }
}
