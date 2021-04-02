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
    {
        public ValidationModel con;
        public SegmentModel details;
        public Type Fields;
        public string sectionCodeJson;


        public SegementDetailPageModel(SegmentModel details1, ValidationModel con1)
        {
            this.con = con1;
            this.details = details1;

            this.sectionCodeJson = JsonConvert.SerializeObject(con.SectionCode);
        }
        

    }
}
