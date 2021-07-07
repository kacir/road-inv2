using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoadInv.DB;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using RoadInv.Models;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace RoadInv.Controllers
{
    /*
         * This controller is responsible for rendering
         * and controlling behavior on the system changes tab.
         * We might want to add a service layer in order to handle 
         * DB calls and statement formatting
     */
    public class SystemChangesController : Controller
    {
        private readonly roadinvContext _context;
        public SystemChangesController(roadinvContext context)
        {
            _context = context;
        }

        [Authorize(Policy = "admin-only")]                                                      //policy is created in startup.cs under AddAuthorization
        [Route("system_changes/nhs")]
        [Route("system_changes/nhs.html")]
        public async Task<IActionResult> system_changes_nhs(SystemChangesPageModel pageModel)
        {
            string NAME = HttpContext.User.Identity.Name;
            int pageSize = 50;
            int pageNumber = (pageModel.Page ?? 1); //TODO: separate paging for excludeNHS table

            var roads = from r in _context.RoadInvs
                        where r.Nhs != "0" && r.Nhs != "" && r.Nhs != null //do we want to filter out nulls, empty strings etc?
                        select r;


            var excNh = from r in _context.ExcludeNhs
                        select r;

            var diss = from r in _context.DissolveNhsViews
                       select r;

            

            var validationModel = new ValidationModel(_context);
            
            pageModel.Districts = validationModel.AH_District.ConvertAll(a => { return new SelectListItem { Text = a.DistrictNumber, Value = a.DistrictNumber, Selected = false }; });
            pageModel.Counties = validationModel.AH_County.ConvertAll(a => { return new SelectListItem { Text = a.CountyNumber + " - " + a.County, Value = a.CountyNumber, Selected = false }; });
            pageModel.Directions = validationModel.LOG_DIRECT.ConvertAll(a => { return new SelectListItem { Text = a.Domainvalue, Value = a.Domainvalue, Selected = false }; });
            pageModel.NHS_vals = validationModel.NHS.ConvertAll(a => { return new SelectListItem { Text = a.Domainvalue, Value = a.Domainvalue, Selected = false }; });

            ViewBag.CurrentSort = pageModel.SortOrder;

            roads = roads.OrderBy(r => r.AhRoute).ThenBy(r=> r.AhBlm);

            if (!String.IsNullOrEmpty(pageModel.District))
            {
                roads = roads.Where(r => r.AhDistrict.Equals(pageModel.District));
            }
            if (!String.IsNullOrEmpty(pageModel.County))
            {
                roads = roads.Where(r => r.AhCounty.Equals(pageModel.County));
            }
            if (!String.IsNullOrEmpty(pageModel.Route))
            {
                roads = roads.Where(r => r.AhRoute.Equals(pageModel.Route.Trim()));
            }
            if (!String.IsNullOrEmpty(pageModel.Section))
            {
                roads = roads.Where(r => r.AhSection.Equals(pageModel.Section));
            }
            if (!pageModel.Logmile.Equals(null))
            {
                roads = roads.Where(r => r.AhBlm.Equals(pageModel.Logmile) || r.AhElm.Equals(pageModel.Logmile));
            }
            if (!String.IsNullOrEmpty(pageModel.Direction))
            {
                roads = roads.Where(r => r.LogDirect.Equals(pageModel.Direction));
            }
            if (!String.IsNullOrEmpty(pageModel.NHS))
            {
                roads = roads.Where(r => r.Nhs.Equals(pageModel.NHS));
            }

            switch (pageModel.SortOrder)
            {
                case "name_desc":
                    roads = roads.OrderBy(r => r.AhRoute).ThenBy(r => r.AhBlm);
                    break;
                default:
                    roads = roads.OrderBy(r => r.AhRoute).ThenBy(r => r.AhBlm);
                    break;
            }
            pageModel.roadInvs = await roads.ToPagedListAsync(pageNumber, pageSize);
            pageModel.ExcludeNhs = await excNh.ToPagedListAsync(pageNumber, pageSize);
            
            if (pageModel.Dissolve == "Segment")
            {

                if (!String.IsNullOrEmpty(pageModel.County))
                {
                    diss = diss.Where(r => r.AhCounty.Equals(pageModel.County)); //will need to scaffold
                }
                if (!String.IsNullOrEmpty(pageModel.Section))
                {
                    diss = diss.Where(r => r.AhSection.Equals(pageModel.Section));
                }
                if (!String.IsNullOrEmpty(pageModel.Route))
                {
                    diss = diss.Where(r => r.AhRoute.Equals(pageModel.Route));
                }
                if (!String.IsNullOrEmpty(pageModel.Direction))
                {
                    diss = diss.Where(r => r.LogDirect.Equals(pageModel.Direction));
                }
                pageModel.DissolveNhsViews = await diss.ToPagedListAsync(pageNumber, pageSize);
            }
            return View(pageModel);
        }

        [Route("system_changes/aphn")]
        [Route("system_changes/aphn.html")]
        public async Task<IActionResult> system_changes_aphn(SystemChangesPageModel pageModel)
        {
            int pageSize = 50;
            int pageNumber = (pageModel.Page ?? 1); //TODO: separate paging for excludeNHS table

            var roads = from r in _context.RoadInvs
                        where r.Aphn != "" && r.Aphn !=null
                        select r;

            var excAp = from r in _context.ExcludeAphns
                        select r;

            var diss = from r in _context.DissolveAphnViews
                       select r;
            

            var validationModel = new ValidationModel(_context);

            pageModel.Districts = validationModel.AH_District.ConvertAll(a => { return new SelectListItem { Text = a.DistrictNumber, Value = a.DistrictNumber, Selected = false }; });
            pageModel.Counties = validationModel.AH_County.ConvertAll(a => { return new SelectListItem { Text = a.CountyNumber + " - " + a.County, Value = a.CountyNumber, Selected = false }; });
            pageModel.Directions = validationModel.LOG_DIRECT.ConvertAll(a => { return new SelectListItem { Text = a.Domainvalue, Value = a.Domainvalue, Selected = false }; });
            pageModel.APHN_vals = validationModel.APHN.ConvertAll(a => { return new SelectListItem { Text = a.Domainvalue, Value = a.Domainvalue, Selected = false }; });

            ViewBag.CurrentSort = pageModel.SortOrder;

            if (!String.IsNullOrEmpty(pageModel.District))
            {
                roads = roads.Where(r => r.AhDistrict.Equals(pageModel.District));
            }
            if (!String.IsNullOrEmpty(pageModel.County))
            {
                roads = roads.Where(r => r.AhCounty.Equals(pageModel.County));
            }
            if (!String.IsNullOrEmpty(pageModel.Route))
            {
                roads = roads.Where(r => r.AhRoute.Equals(pageModel.Route));
            }
            if (!String.IsNullOrEmpty(pageModel.Section))
            {
                roads = roads.Where(r => r.AhSection.Equals(pageModel.Section));
            }
            if (!pageModel.Logmile.Equals(null))
            {
                roads = roads.Where(r => r.AhBlm.Equals(pageModel.Logmile) || r.AhElm.Equals(pageModel.Logmile));
            }
            if (!String.IsNullOrEmpty(pageModel.Direction))
            {
                roads = roads.Where(r => r.LogDirect.Equals(pageModel.Direction));
            }
            if (!String.IsNullOrEmpty(pageModel.APHN))
            {
                roads = roads.Where(r => r.Aphn.Equals(pageModel.APHN));
            }

            switch (pageModel.SortOrder)
            {
                case "name_desc":
                    roads = roads.OrderByDescending(r => r.Aphn);
                    break;
                default:
                    roads = roads.OrderBy(r => r.Aphn);
                    break;
            }
            ViewBag.CurrentSort = pageModel.SortOrder;

            roads = roads.OrderBy(r => r.Aphn);
            pageModel.roadInvs = await roads.ToPagedListAsync(pageNumber, pageSize);
            pageModel.ExcludeAphn = await excAp.ToPagedListAsync(pageNumber, pageSize);
            if (pageModel.Dissolve == "Segment")
            {
                if (!String.IsNullOrEmpty(pageModel.County))
                {
                    diss = diss.Where(r => r.AhCounty.Equals(pageModel.County)); //will need to scaffold
                }
                if (!String.IsNullOrEmpty(pageModel.Section))
                {
                    diss = diss.Where(r => r.AhSection.Equals(pageModel.Section));
                }
                if (!String.IsNullOrEmpty(pageModel.Route))
                {
                    diss = diss.Where(r => r.AhRoute.Equals(pageModel.Route));
                }
                if (!String.IsNullOrEmpty(pageModel.Direction))
                {
                    diss = diss.Where(r => r.LogDirect.Equals(pageModel.Direction));
                }
                pageModel.DissolveAphnViews = await diss.ToPagedListAsync(pageNumber, pageSize);
            }
            return View(pageModel);
        }


        [Route("system_changes/func")]
        [Route("system_changes/func.html")]
        public async Task<IActionResult> system_changes_func(SystemChangesPageModel pageModel)
        {
            int pageSize = 50;
            int pageNumber = (pageModel.Page ?? 1); //TODO: separate paging for excludeNHS table

            var roads = from r in _context.RoadInvs
                        where r.FuncClass != "7" && r.FuncClass !=null && r.FuncClass !=""
                        select r;


            var diss = from r in _context.DissolveFuncViews
                       select r;

            var validationModel = new ValidationModel(_context);

            pageModel.Districts = validationModel.AH_District.ConvertAll(a => { return new SelectListItem { Text = a.DistrictNumber, Value = a.DistrictNumber, Selected = false }; });
            pageModel.Counties = validationModel.AH_County.ConvertAll(a => { return new SelectListItem { Text = a.CountyNumber + " - " + a.County, Value = a.CountyNumber, Selected = false }; });
            pageModel.Directions = validationModel.LOG_DIRECT.ConvertAll(a => { return new SelectListItem { Text = a.Domainvalue, Value = a.Domainvalue, Selected = false }; });
            pageModel.FuncClass_vals = validationModel.FuncClass.ConvertAll(a => { return new SelectListItem { Text = a.Domainvalue, Value = a.Domainvalue, Selected = false }; });
            ViewBag.CurrentSort = pageModel.SortOrder;

            if (!String.IsNullOrEmpty(pageModel.District))
            {
                roads = roads.Where(r => r.AhDistrict.Equals(pageModel.District));
            }
            if (!String.IsNullOrEmpty(pageModel.County))
            {
                roads = roads.Where(r => r.AhCounty.Equals(pageModel.County));
            }
            if (!String.IsNullOrEmpty(pageModel.Route))
            {
                roads = roads.Where(r => r.AhRoute.Equals(pageModel.Route));
            }
            if (!String.IsNullOrEmpty(pageModel.Section))
            {
                roads = roads.Where(r => r.AhSection.Equals(pageModel.Section));
            }
            if (!pageModel.Logmile.Equals(null))
            {
                roads = roads.Where(r => r.AhBlm.Equals(pageModel.Logmile) || r.AhElm.Equals(pageModel.Logmile));
            }
            if (!String.IsNullOrEmpty(pageModel.Direction))
            {
                roads = roads.Where(r => r.LogDirect.Equals(pageModel.Direction));
            }
            if (!String.IsNullOrEmpty(pageModel.FuncClass))
            {
                roads = roads.Where(r => r.FuncClass.Equals(pageModel.FuncClass));
            }

            switch (pageModel.SortOrder)
            {
                case "name_desc":
                    roads = roads.OrderByDescending(r => r.FuncClass);
                    break;
                default:
                    roads = roads.OrderBy(r => r.FuncClass);
                    break;
            }
            roads = roads.OrderBy(r => r.FuncClass);
            pageModel.roadInvs = await roads.ToPagedListAsync(pageNumber, pageSize);
            if (pageModel.Dissolve == "Segment")
            {
                if (!String.IsNullOrEmpty(pageModel.County))
                {
                    diss = diss.Where(r => r.AhCounty.Equals(pageModel.County)); //will need to scaffold
                }
                if (!String.IsNullOrEmpty(pageModel.Section))
                {
                    diss = diss.Where(r => r.AhSection.Equals(pageModel.Section));
                }
                if (!String.IsNullOrEmpty(pageModel.Route))
                {
                    diss = diss.Where(r => r.AhRoute.Equals(pageModel.Route));
                }
                if (!String.IsNullOrEmpty(pageModel.Direction))
                {
                    diss = diss.Where(r => r.LogDirect.Equals(pageModel.Direction));
                }
                pageModel.DissolveFuncViews = await diss.ToPagedListAsync(pageNumber, pageSize);
            }
            return View(pageModel);
        }

        [Route("system_changes/special")]
        [Route("system_changes/special.html")]
        public async Task<IActionResult> system_changes_special(SystemChangesPageModel pageModel)
        {

            int pageSize = 50;
            string userid = HttpContext.User.Identity.Name;
            int pageNumber = (pageModel.Page ?? 1); //TODO: separate paging for excludeNHS table

            var roads = from r in _context.RoadInvs
                        where r.SpecialSystems != ""
                        select r;


            var excNh = from r in _context.ExcludeSpecialSystems
                        select r;

            var diss = from r in _context.DissolveSpecialSystemsViews
                       select r;

            var validationModel = new ValidationModel(_context);

            pageModel.Districts = validationModel.AH_District.ConvertAll(a => { return new SelectListItem { Text = a.DistrictNumber, Value = a.DistrictNumber, Selected = false }; });
            pageModel.Counties = validationModel.AH_County.ConvertAll(a => { return new SelectListItem { Text = a.CountyNumber + " - " + a.County, Value = a.CountyNumber, Selected = false }; });
            pageModel.Directions = validationModel.LOG_DIRECT.ConvertAll(a => { return new SelectListItem { Text = a.Domainvalue, Value = a.Domainvalue, Selected = false }; });
            pageModel.SpecialSystem_vals = validationModel.SpecialSystems.ConvertAll(a => { return new SelectListItem { Text = a.Domainvalue, Value = a.Domainvalue, Selected = false }; });
            ViewBag.CurrentSort = pageModel.SortOrder;

            if (!String.IsNullOrEmpty(pageModel.District))
            {
                roads = roads.Where(r => r.AhDistrict.Equals(pageModel.District));
            }
            if (!String.IsNullOrEmpty(pageModel.County))
            {
                roads = roads.Where(r => r.AhCounty.Equals(pageModel.County));
            }
            if (!String.IsNullOrEmpty(pageModel.Route))
            {
                roads = roads.Where(r => r.AhRoute.Equals(pageModel.Route));
            }
            if (!String.IsNullOrEmpty(pageModel.Section))
            {
                roads = roads.Where(r => r.AhSection.Equals(pageModel.Section));
            }
            if (!pageModel.Logmile.Equals(null))
            {
                roads = roads.Where(r => r.AhBlm.Equals(pageModel.Logmile) || r.AhElm.Equals(pageModel.Logmile));
            }
            if (!String.IsNullOrEmpty(pageModel.Direction))
            {
                roads = roads.Where(r => r.LogDirect.Equals(pageModel.Direction));
            }
            if (!String.IsNullOrEmpty(pageModel.SpecialSystem))
            {
                roads = roads.Where(r => r.SpecialSystems.Equals(pageModel.SpecialSystem));
            }

            switch (pageModel.SortOrder)
            {
                case "name_desc":
                    roads = roads.OrderByDescending(r => r.SpecialSystems);
                    break;
                default:
                    roads = roads.OrderBy(r => r.SpecialSystems);
                    break;
            }

            ViewBag.CurrentSort = pageModel.SortOrder;

            roads = roads.OrderBy(r => r.FuncClass);
            pageModel.roadInvs = await roads.ToPagedListAsync(pageNumber, pageSize);
            pageModel.ExcludeSpecials = await excNh.ToPagedListAsync(pageNumber, pageSize);
            if (pageModel.Dissolve == "Segment")
            {
                if (!String.IsNullOrEmpty(pageModel.County))
                {
                    diss = diss.Where(r => r.AhCounty.Equals(pageModel.County)); //will need to scaffold
                }
                if (!String.IsNullOrEmpty(pageModel.Section))
                {
                    diss = diss.Where(r => r.AhSection.Equals(pageModel.Section));
                }
                if (!String.IsNullOrEmpty(pageModel.Route))
                {
                    diss = diss.Where(r => r.AhRoute.Equals(pageModel.Route));
                }
                if (!String.IsNullOrEmpty(pageModel.Direction))
                {
                    diss = diss.Where(r => r.LogDirect.Equals(pageModel.Direction));
                }
                pageModel.DissolveSpecialSystemsViews = await diss.ToPagedListAsync(pageNumber, pageSize);
            }
            return View(pageModel);
        }
        [Authorize(Policy = "admin-only")]
        [HttpPost]
        [Route("system_changes/bulk_update")]
        [Route("system_changes/bulk_update.html")]
        public IActionResult Bulk_Update(SystemChangesPageModel pageModel)
        {
            if (ModelState.IsValid)
            {
                //pageModel.PreviewChanges = false;

                var ApiController = new ApiController(_context);

                var roadID = pageModel.County + 'x' + pageModel.Route + 'x' + pageModel.Section + 'x' + pageModel.Direction;

                ViewData["County"] = pageModel.County;
                if (pageModel.NHS != null)
                {
                    //var result = ApiController.ValidateBulk(roadID, pageModel.BLM, pageModel.ELM);//removed pageModel.NHS
                    //string json = JsonConvert.SerializeObject(result, Formatting.Indented); //testing
                    ApiController.ImplementBulkEditNHS(roadID, pageModel.BLM, pageModel.ELM, pageModel.NHS);
                    return RedirectToAction("system_changes_nhs", pageModel);
                }
                else if (pageModel.APHN != null)
                {
                    //var result = ApiController.ValidateBulk(roadID, pageModel.BLM, pageModel.ELM); //removed pageModel.APHN
                    //string json = JsonConvert.SerializeObject(result, Formatting.Indented); //testing
                    ApiController.ImplementBulkEditAPHN(roadID, pageModel.BLM, pageModel.ELM, pageModel.APHN);
                    return RedirectToAction("system_changes_aphn", pageModel);
                }
                else if (pageModel.FuncClass != null)
                {
                    //ApiController.ValidateBulk(roadID, pageModel.BLM, pageModel.ELM);//removed pageModel.FuncClass
                    ApiController.ImplementBulkEditFuncClass(roadID, pageModel.BLM, pageModel.ELM, pageModel.FuncClass);
                    return RedirectToAction("system_changes_func", pageModel);
                }
                else if (pageModel.SpecialSystem != null)
                {
                    //ApiController.ValidateBulk(roadID, pageModel.BLM, pageModel.ELM);//removed pageModel.SpecialSystem
                    ApiController.ImplementBulkEditSpecial(roadID, pageModel.BLM, pageModel.ELM, pageModel.SpecialSystem);
                    return RedirectToAction("system_changes_special", pageModel);
                }
                
            }
            string baseUrl = string.Format("{0}://{1}",HttpContext.Request.Scheme, HttpContext.Request.Host);
            return Redirect(baseUrl);//need to figure out how to go back to previous screen on close
        }

        [Authorize(Policy = "admin-only")]
        //[HttpPost]
        [Route("system_changes/preview_changes")]
        [Route("system_changes/preview_changes.html")]
        public IActionResult preview_changes(SystemChangesPageModel pageModel)
        {
            
            var roadID = pageModel.County + 'x' + pageModel.Route + 'x' + pageModel.Section + 'x' + pageModel.Direction;

            //could add case statement like in the Bulk_Update action to change below values to reflect designation type

            //if pageModel.APHN is not null
            //send APHN report to view
            pageModel.APHN_Length = (from r in _context.RoadInvs //page model demonstrates flexibility in case we want to use this value again                           
                                     where r.Aphn != "0" && r.AhRoadId == roadID //we could just as easily use a viewbag like below
                                     select r.AhLength).Sum();

            ViewBag.lenModified = pageModel.ELM - pageModel.BLM;

            ViewBag.TotalLengthOnAPHN = (from r in _context.RoadInvs 
                                     where r.Aphn != "0" && r.AhRoadId == roadID
                                         select r.AhLength).Sum();
            
            ViewBag.TotalLengthOffAPHN = (from r in _context.RoadInvs
                                          where r.Aphn == "0" && r.AhRoadId == roadID
                                          select r.AhLength).Sum();

            //the page model will be saved and the values will return in the forms
            return View(pageModel);
        }
        
        private bool RoadInvExists(int id)
        {
            return _context.RoadInvs.Any(e => e.Id == id);
        }
    }
}
