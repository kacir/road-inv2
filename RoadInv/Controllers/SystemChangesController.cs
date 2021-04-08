using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoadInv.DB;

namespace RoadInv.Controllers
{
    public class SystemChangesController : Controller
    {
        private roadinvContext _context;
        public SystemChangesController(roadinvContext context)
        {
            this._context = context;
        }


        public IActionResult APHN()
        {
            return View("system_changes_aphn");
        }


        public IActionResult NHS()
        {
            return View("system_changes_nhs");
        }

        public IActionResult Func()
        {
            return View("system_changes_func");
        }
    }
}
