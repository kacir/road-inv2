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


        [Route("system_changes/aphn")]
        [Route("system_changes/aphn.html")]
        public IActionResult APHN()
        {
            return View("system_changes_aphn");
        }

        [Route("system_changes/nhs")]
        [Route("system_changes/nhs.html")]
        public IActionResult NHS()
        {
            return View("system_changes_nhs");
        }

        [Route("system_changes/func")]
        [Route("system_changes/func.html")]
        public IActionResult Func()
        {
            return View("system_changes_func");
        }
    }
}
