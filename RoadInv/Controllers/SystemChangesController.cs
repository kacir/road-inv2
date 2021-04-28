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
        public async Task<IActionResult> system_changes_nhs(string sortOrder, string district, string county, string route, string section, string logmile, int? page)
        {
            int pageSize = 50;
            int pageNumber = (page ?? 1);

            var roads = from r in _context.RoadInvs
                        where r.Nhs != "0"
                        select r;

            var excNh = from r in _context.ExcludeNhs
                        select r;

            //var diss = from r in _context.DissolveNhsViews
            //           select r;

            var mymodel = new SystemChangesPageModel();

            mymodel.Counties = GetAllCounties(); //populates drop down
            mymodel.Districts = GetAllDistricts();

            ViewBag.CurrentSort = sortOrder;

            roads = roads.OrderBy(r => r.Nhs); 

            if (district != null)
            {
                page = 1;
                mymodel.District = district;
            }

            if (county != null)
            {
                page = 1;
                mymodel.County = county;
            }

            if (route != null)
            {
                page = 1;
                mymodel.Route = route;
            }

            if (section != null)
            {
                page = 1;
                mymodel.Section = section;
            }

            if (logmile != null)
            {
                page = 1;
                mymodel.Logmile = logmile;
            }

            if (!String.IsNullOrEmpty(district))
            {
                roads = roads.Where(r => r.AhDistrict.Equals(district));
            }
            if (!String.IsNullOrEmpty(county)) 
            {
                roads = roads.Where(r => r.AhCounty.Equals(county));
            }
            if (!String.IsNullOrEmpty(route))
            {
                roads = roads.Where(r => r.AhRoute.Equals(route));
            }
            if (!String.IsNullOrEmpty(section))
            {
                roads = roads.Where(r => r.AhSection.Equals(section));
            }
            if (!String.IsNullOrEmpty(logmile))
            {
                roads = roads.Where(r => r.AhBlm.Equals(Convert.ToDecimal(logmile)) || r.AhElm.Equals(Convert.ToDecimal(logmile)));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    roads = roads.OrderByDescending(r => r.Nhs);
                    break;
                default: 
                    roads = roads.OrderBy(r => r.Nhs);
                    break;
            }
            mymodel.roadInvs = await roads.ToPagedListAsync(pageNumber, pageSize); //TODO: the page number variable is shared between models
            mymodel.ExcludeNhs = await excNh.ToPagedListAsync(pageNumber, pageSize); 
            //mymodel.DissolveNhsViews = await diss.ToPagedListAsync(pageNumber, pageSize);
            return View(mymodel);
        }

        private IEnumerable<SelectListItem> GetAllCounties() //TODO: need to move this function to a seperate class
        {
            IEnumerable<SelectListItem> list = from s in _context.RoadInvs
                                               select new SelectListItem
                                               {
                                                   Selected = false,
                                                   Text = s.AhCounty,
                                                   Value = s.AhCounty
                                               };
            list = list.GroupBy(x => x.Text).Select(x => x.First()).ToList();
            list = list.OrderBy(x => x.Value); //funky order. TODO: figure out why conversion doesn't work
            return list; 
        }

        private IEnumerable<SelectListItem> GetAllDistricts()//TODO: need to move this function to a seperate class
        {
            IEnumerable<SelectListItem> list = from s in _context.RoadInvs
                                               select new SelectListItem
                                               {
                                                   Selected = false,
                                                   Text = s.AhDistrict,
                                                   Value = s.AhDistrict
                                               };
            list = list.GroupBy(x => x.Text).Select(x => x.First()).ToList();
            list = list.OrderBy(x => Convert.ToInt32(x.Value));
            return list; 
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
    }
}
