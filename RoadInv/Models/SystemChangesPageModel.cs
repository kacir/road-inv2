using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace RoadInv.Models
{

    public class SystemChangesPageModel
    {
        public IPagedList<RoadInv.DB.RoadInv> roadInvs { get; set; }
        public IPagedList<RoadInv.DB.DissolveNhsView> DissolveNhsViews { get; set; }
        public IPagedList<RoadInv.DB.DissolveAphnView> DissolveAphnViews { get; set; }
        public IPagedList<RoadInv.DB.DissolveFuncView> DissolveFuncViews { get; set; }
        public IPagedList<RoadInv.DB.DissolveSpecialSystemsView> DissolveSpecialSystemsViews { get; set; }
        public IPagedList<RoadInv.DB.ExcludeNh> ExcludeNhs { get; set; }
        public IPagedList<RoadInv.DB.ExcludeAphn> ExcludeAphn { get; set; }
        public IPagedList<RoadInv.DB.ExcludeSpecialSystem> ExcludeSpecials { get; set; }
        public IEnumerable<SelectListItem> Counties{ get; set; }
        public IEnumerable<SelectListItem> Districts { get; set; }
        public IEnumerable<SelectListItem> Directions { get; set; }
        public IEnumerable<SelectListItem> NHS_vals { get; set; }
        public IEnumerable<SelectListItem> FuncClass_vals { get; set; }
        public IEnumerable<SelectListItem> APHN_vals { get; set; }
        public IEnumerable<SelectListItem> SpecialSystem_vals { get; set; }

        public string RoadID { get; set; }
        public string District { get; set; }
        public string County { get; set; }
        public string Route { get; set; }
        public string Section { get; set; }
        public decimal? Logmile { get; set; }
        public string SortOrder { get; set; }
        public string Dissolve { get; set; }
        public string Direction { get; set; }
        public decimal BLM { get; set; }
        public decimal ELM { get; set; }
        public int? Page { get; set; }
        public string NHS { get; set; }
        public string SpecialSystem { get; set; }
        public string FuncClass { get; set; }
        public string APHN { get; set; }

        public enum DissolveSelect
        {
            Segment,
            ARNOLD_ID
        }

    }
}
