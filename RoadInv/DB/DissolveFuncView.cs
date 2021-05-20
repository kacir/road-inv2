using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RoadInv.DB
{
    public partial class DissolveFuncView
    {
        public int? Id { get; set; }
        public string AhCounty { get; set; }
        public string AhRoute { get; set; }
        public string AhSection { get; set; }
        public string LogDirect { get; set; }
        public string AhRoadId { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}")]
        public decimal? AhBlm { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}")]
        public decimal? AhElm { get; set; }
        public string FuncClass { get; set; }
    }
}
