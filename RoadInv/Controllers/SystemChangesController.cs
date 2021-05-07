using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoadInv.DB;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using RoadInv.Models;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RoadInv.Controllers
{
    public class SystemChangesController : Controller
    {
        private readonly roadinvContext _context;
        public SystemChangesController(roadinvContext context)
        {
            _context = context;
        }

        // GET: 
        [Route("system_changes/nhs")]
        [Route("system_changes/nhs.html")]
        public async Task<IActionResult> system_changes_nhs(SystemChangesPageModel pageModel)
        {
            int pageSize = 50;
            int pageNumber = (pageModel.Page ?? 1); //TODO: separate paging for excludeNHS table

            var roads = from r in _context.RoadInvs
                        where r.Nhs != "0"
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

            roads = roads.OrderBy(r => r.Nhs);

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
            if (!pageModel.BLM.Equals(null))
            {
                roads = roads.Where(r => r.AhBlm.Equals(pageModel.BLM));
            }
            if (!pageModel.ELM.Equals(null))
            {
                roads = roads.Where(r => r.AhBlm.Equals(pageModel.ELM));
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
                    roads = roads.OrderByDescending(r => r.Nhs);
                    break;
                default:
                    roads = roads.OrderBy(r => r.Nhs);
                    break;
            }
            pageModel.roadInvs = await roads.ToPagedListAsync(pageNumber, pageSize);
            pageModel.ExcludeNhs = await excNh.ToPagedListAsync(pageNumber, pageSize);
            
            if (pageModel.Dissolve == "Segment")
            {
                pageModel.DissolveNhsViews = await diss.ToPagedListAsync(pageNumber, pageSize);
            }
            return View(pageModel);
        }

        [HttpPost]
        [Route("system_changes/nhs_update")]
        [Route("system_changes/nhs_update.html")]
        public IActionResult NHS_Update(SystemChangesPageModel pageModel)
        {
            if (ModelState.IsValid)
            {
                var roads = from r in _context.RoadInvs
                            where r.Nhs != "0"
                            select r;
                
                if (!String.IsNullOrEmpty(pageModel.County))
                {
                    roads = roads.Where(r => r.AhCounty.Equals(pageModel.County));
                }
                if (!String.IsNullOrEmpty(pageModel.Route))
                {
                    roads = roads.Where(r => r.AhRoute.Equals(pageModel.Route));
                }
                if (!String.IsNullOrEmpty(pageModel.Direction))
                {
                    roads = roads.Where(r => r.LogDirect.Equals(pageModel.Direction));
                }
                if (!pageModel.BLM.Equals(null))
                {
                    roads = roads.Where(r => r.AhBlm.Equals(pageModel.BLM));
                }
                if (!pageModel.ELM.Equals(null))
                {
                    roads = roads.Where(r => r.AhBlm.Equals(pageModel.ELM));
                }
                if (!String.IsNullOrEmpty(pageModel.NHS))
                {
                    foreach (var road in roads)
                    {
                        road.Nhs = pageModel.NHS; 
                    }
                    _context.SaveChanges();
                }
  
            }
            return RedirectToAction("system_changes_nhs");
        }

        // GET: 
        [Route("system_changes/nhs/Details")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roadInv = await _context.RoadInvs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roadInv == null)
            {
                return NotFound();
            }

            return View(roadInv);
        }

        // GET: 
        public IActionResult Create()
        {
            return View();
        }

        // POST: 
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AhDistrict,AhCounty,AhRoute,AhSection,LogDirect,AhRoadId,GovermentCode,RuralUrbanArea,UrbanAreaCode,FuncClass,Nhs,SystemStatus,SpecialSystems,BothDirectionNumLanes,OneDirectionNumLanes,Comment1,TypeRoad,RouteSign,Aphn,Access,TypeOperation,YearBuilt,YearRecon,MedianWidth,LaneWidth,SurfaceWidth,RightShoulderSurface,LeftShoulderSurface,RightShoulderWidth,LeftShoulderWidth,RoadwayWidth,ExtraLanes,YearAdt,MedianType,SurfaceType,AlternativeRouteName,LegacyId,LegacyBlm,LegacyElm,UpdateUserId,UpdateDate,Gisid,GiscreateDate,GiscreatedUser,GislastEditedUser,GislastEditedDate,ArnoldConv,AhBlm,AhElm,AhLength")] DB.RoadInv roadInv)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roadInv);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roadInv);
        }

        // GET: RoadInvs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roadInv = await _context.RoadInvs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roadInv == null)
            {
                return NotFound();
            }

            return View(roadInv);
        }

        // POST: RoadInvs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roadInv = await _context.RoadInvs.FindAsync(id);
            _context.RoadInvs.Remove(roadInv);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoadInvExists(int id)
        {
            return _context.RoadInvs.Any(e => e.Id == id);
        }

        [Route("system_changes/aphn")]
        [Route("system_changes/aphn.html")]
        public IActionResult APHN()
        {
            return View("system_changes_aphn");
        }


        [Route("system_changes/func")]
        [Route("system_changes/func.html")]
        public IActionResult Func()
        {
            return View("system_changes_func");
        }

        [Route("system_changes/special")]
        [Route("system_changes/special.html")]
        public async Task<IActionResult> system_changes_special(SystemChangesPageModel pageModel)
        {
            int pageSize = 50;
            int pageNumber = (pageModel.Page ?? 1); //TODO: separate paging for excludeNHS table

            var roads = from r in _context.RoadInvs
                        where r.Nhs != "0"
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

            roads = roads.OrderBy(r => r.Nhs);
            pageModel.roadInvs = await roads.ToPagedListAsync(pageNumber, pageSize);
            pageModel.ExcludeNhs = await excNh.ToPagedListAsync(pageNumber, pageSize);
            return View(pageModel);
        }
    }
}
