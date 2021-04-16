using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoadInv.DB;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

//TODO: add bulk edits

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
        public async Task<IActionResult> system_changes_nhs(string sortOrder, string currentFilter, string currentFilter1, string currentFilter2, string currentFilter3, string currentFilter4, int? page, string County, string Route, string Section, string Logmile, string District)
        {
            
            
            int pageSize = 16;
            int pageNumber = (page ?? 1);

            var roads = from r in _context.RoadInvs
                        where r.Nhs != "0"
                        select r;

            ViewBag.CurrentSort = sortOrder;

            roads = roads.OrderBy(r => r.Nhs);

            if (District != null)//need all search fields to persist
            {
                page = 1;
            }
            else
            {
                District = currentFilter;//There has to be a better way to do this

            }
            ViewBag.currentFilter = District; //saving filters

            if (County != null)
            {
                page = 1;
            }
            else
            {
                County = currentFilter1;

            }
            ViewBag.currentFilter1 = County;//need to find better way to do this

            if (Route != null)
            {
                page = 1;
            }
            else
            {
                Route = currentFilter2;

            }
            ViewBag.currentFilter2 = Route;//need to find better way to do this

            if (Section != null)
            {
                page = 1;
            }
            else
            {
                Section = currentFilter3;

            }
            ViewBag.currentFilter3 = Section;//need to find better way to do this

            if (Logmile != null)
            {
                page = 1;
            }
            else
            {
                Logmile = currentFilter4;

            }
            ViewBag.currentFilter4 = Logmile;//need to find better way to do this

            if (!String.IsNullOrEmpty(County))
            {
                roads = roads.Where(r => r.AhCounty.Equals(County));
            }
            if (!String.IsNullOrEmpty(Route))
            {
                roads = roads.Where(r => r.AhRoute.Equals(Route));
            }
            if (!String.IsNullOrEmpty(Section))
            {
                roads = roads.Where(r => r.AhSection.Equals(Section));
            }
            if (!String.IsNullOrEmpty(Logmile))
            {
                roads = roads.Where(r => r.AhBlm.Equals(Convert.ToDecimal(Logmile)) || r.AhElm.Equals(Convert.ToDecimal(Logmile)));
            }
            if (!String.IsNullOrEmpty(District))
            {
                roads = roads.Where(r => r.AhDistrict.Equals(District));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    roads = roads.OrderByDescending(r => r.Nhs);
                    break;
                default:  // NHS ascending 
                    roads = roads.OrderBy(r => r.Nhs);
                    break;
            }

            return View(await roads.ToPagedListAsync(pageNumber, pageSize));
            //return View(await roads.ToListAsync());
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

        [Route("system_changes/nhs/NHS_Edit/{id:int}")]
        
        public async Task<IActionResult> NHS_Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roadInv = await _context.RoadInvs.FindAsync(id);
            if (roadInv == null)
            {
                return NotFound();
            }
            return View(roadInv);
        }

        // POST: 
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Route("system_changes/nhs/NHS_Edit")]
        [Route("system_changes/nhs/NHS_Edit.html")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NHS_Edit(int id, [Bind("Id,AhDistrict,AhCounty,AhRoute,AhSection,LogDirect,AhRoadId,GovermentCode,RuralUrbanArea,UrbanAreaCode,FuncClass,Nhs,SystemStatus,SpecialSystems,BothDirectionNumLanes,OneDirectionNumLanes,Comment1,TypeRoad,RouteSign,Aphn,Access,TypeOperation,YearBuilt,YearRecon,MedianWidth,LaneWidth,SurfaceWidth,RightShoulderSurface,LeftShoulderSurface,RightShoulderWidth,LeftShoulderWidth,RoadwayWidth,ExtraLanes,YearAdt,MedianType,SurfaceType,AlternativeRouteName,LegacyId,LegacyBlm,LegacyElm,UpdateUserId,UpdateDate,Gisid,GiscreateDate,GiscreatedUser,GislastEditedUser,GislastEditedDate,ArnoldConv,AhBlm,AhElm,AhLength")] DB.RoadInv roadInv)
        {
            if (id != roadInv.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roadInv);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoadInvExists(roadInv.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
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
