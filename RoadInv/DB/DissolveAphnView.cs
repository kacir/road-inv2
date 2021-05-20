using System;
using System.Collections.Generic;

#nullable disable

namespace RoadInv.DB
{
    public partial class DissolveAphnView
    {
        public int? Id { get; set; }
        public string AhCounty { get; set; }
        public string AhRoute { get; set; }
        public string AhSection { get; set; }
        public string LogDirect { get; set; }
        public string AhRoadId { get; set; }
        public decimal? AhBlm { get; set; }
        public decimal? AhElm { get; set; }
        public string Aphn { get; set; }
    }
}
