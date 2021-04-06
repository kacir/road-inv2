using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoadInv.DB;
using Z.EntityFramework.Plus;
using RoadInv.Models;
using Newtonsoft.Json;

namespace RoadInv.Models
{
    
    public class SegementDetailPageModel
        // provides all information needed for the segment details page to populate its dropdowns and segment field values
    {
        public ValidationModel con;
        public SegmentModel details;
        public Type Fields;
        public string sectionCodeJson;
        public bool newSegment;


        public SegementDetailPageModel(SegmentModel details1, ValidationModel con1, bool newSegment)
        {
            this.con = con1; //contains all the field dropdown information
            this.details = details1;//contains all field values for the particular segment

            this.sectionCodeJson = JsonConvert.SerializeObject(con.SectionCode);
            this.newSegment = newSegment;
        }
        

    }
}
