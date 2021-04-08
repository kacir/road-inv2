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
        public IQueryable<DB.RoadInv> details;

        public SearchPageModel(ValidationModel con, IQueryable<DB.RoadInv> details)
        {
            this.con = con;
            this.details = details;
        }
    }
}
