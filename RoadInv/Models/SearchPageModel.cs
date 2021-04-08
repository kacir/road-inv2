using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Models
{
    public class SearchPageModel
        //class does not perform any functionality beyond holding data for the markup page to use
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
