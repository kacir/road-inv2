using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Models
{
    public class BulkValidationItemModel
    {
        public List<ErrorItemModel> errors = new();
        public DB.RoadInv segment;
    }
}
