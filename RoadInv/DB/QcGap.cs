﻿using System;
using System.Collections.Generic;

#nullable disable

namespace RoadInv.DB
{
    public partial class QcGap
    {
        public string AhRoadId { get; set; }
        public decimal? AhBlm { get; set; }
        public decimal? AhElm { get; set; }
    }
}
