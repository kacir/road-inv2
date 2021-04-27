using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace RoadInv.Models
{
    public class SystemChangesPageModel
    {
        public IPagedList<RoadInv.DB.RoadInv> roadInvs { get; set; }
        //public IPagedList<RoadInv.DB.DissolveNhsView> DissolveNhsViews { get; set; }
        public IPagedList<RoadInv.DB.ExcludeNh> ExcludeNhs { get; set; }

        public string District { get; set; }
        public string County { get; set; }
        public string Route { get; set; }
        public string Section { get; set; }
        public string Logmile { get; set; }

    }
}
