﻿using System;
using System.Collections.Generic;

#nullable disable

namespace RoadInv.DB
{
    public partial class ExcludeNhs1
    {
        public string AhRoadId { get; set; }
        public string AhCounty { get; set; }
        public string AhSection { get; set; }
        public string LogDirect { get; set; }
        public decimal? AhBlm { get; set; }
        public decimal? AhElm { get; set; }
        public string Nhs { get; set; }
    }
}
