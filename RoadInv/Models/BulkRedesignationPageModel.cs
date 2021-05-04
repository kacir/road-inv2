using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Models
{
    public class BulkRedesignationPageModel
    {
        public int Id { get; set; }
        public string County { get; set; }
        public string Route { get; set; }
        public string Direction { get; set; }
        public decimal BLM { get; set; }
        public decimal ELM { get; set; }
        public string APHN { get; set; }
    }
}
