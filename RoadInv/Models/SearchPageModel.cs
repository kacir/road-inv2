using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Models
{
    public class SearchPageModel
    {
        public ValidationModel con;
        public List<SegmentModel> details;

        public SearchPageModel(ValidationModel con, List<SegmentModel> details)
        {
            this.con = con;
            this.details = details;
        }
    }
}
