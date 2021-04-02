using System;
using System.Collections.Generic;

#nullable disable

namespace RoadInv.DB
{
    public partial class QcOverlap
    {
        public string AhRoadId1 { get; set; }
        public decimal? OverlapBlm { get; set; }
        public decimal? OverlapElm { get; set; }
    }
}
