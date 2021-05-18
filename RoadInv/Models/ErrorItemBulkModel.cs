using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Models
{
    public class ErrorItemBulkModel
    {
        static public DB.RoadInv CloneSegment(DB.RoadInv segmentDetails)
        {

            //clone and set values for new clone
            var duplicate = new DB.RoadInv();

            //customize attributes of duplicate
            duplicate.AhBlm = segmentDetails.AhBlm;
            duplicate.AhCounty = segmentDetails.AhCounty;
            duplicate.AhElm = segmentDetails.AhElm;
            duplicate.AhRoute = segmentDetails.AhRoute;
            duplicate.AhSection = segmentDetails.AhSection;
            duplicate.LogDirect = segmentDetails.LogDirect;

            //explicitly set every single attribute
            duplicate.Access = segmentDetails.Access;
            duplicate.AhDistrict = segmentDetails.AhDistrict;
            duplicate.AlternativeRouteName = segmentDetails.AlternativeRouteName;
            duplicate.Aphn = segmentDetails.Aphn;
            duplicate.ArnoldConv = segmentDetails.ArnoldConv;
            duplicate.Comment1 = segmentDetails.Comment1;
            duplicate.ExtraLanes = segmentDetails.ExtraLanes;
            duplicate.FuncClass = segmentDetails.FuncClass;
            duplicate.GovermentCode = segmentDetails.GovermentCode;
            duplicate.LaneWidth = segmentDetails.LaneWidth;
            duplicate.MedianType = segmentDetails.MedianType;
            duplicate.MedianWidth = segmentDetails.MedianWidth;
            duplicate.Nhs = segmentDetails.Nhs;
            duplicate.RoadwayWidth = segmentDetails.RoadwayWidth;
            duplicate.RouteSign = segmentDetails.RouteSign;
            duplicate.RuralUrbanArea = segmentDetails.RuralUrbanArea;
            duplicate.SpecialSystems = segmentDetails.SpecialSystems;
            duplicate.SurfaceType = segmentDetails.SurfaceType;
            duplicate.SurfaceWidth = segmentDetails.SurfaceWidth;
            duplicate.SystemStatus = segmentDetails.SystemStatus;
            duplicate.TypeOperation = segmentDetails.TypeOperation;
            duplicate.TypeRoad = segmentDetails.TypeRoad;
            duplicate.UrbanAreaCode = segmentDetails.UrbanAreaCode;
            duplicate.YearBuilt = segmentDetails.YearBuilt;
            duplicate.YearRecon = segmentDetails.YearRecon;
            duplicate.BothDirectionNumLanes = segmentDetails.BothDirectionNumLanes;
            duplicate.OneDirectionNumLanes = segmentDetails.OneDirectionNumLanes;
            duplicate.LeftShoulderSurface = segmentDetails.LeftShoulderSurface;
            duplicate.LeftShoulderWidth = segmentDetails.LeftShoulderWidth;
            duplicate.RightShoulderSurface = segmentDetails.RightShoulderSurface;
            duplicate.RightShoulderWidth = segmentDetails.RightShoulderWidth;

            return duplicate;
        }

        //status on the re-designation area only
        public decimal bulkDistance;
        public decimal AH_BLM;
        public decimal AH_ELM;
        public decimal AH_Length;
        public IQueryable<DB.RoadInv> effectedRecords;

        //total legth of records effected even if its outside of the re-designation length
        public decimal effectedLength;
        public int effectedRecordCount;
        public decimal effectedBLM;
        public decimal effectedELM;

        //stats associated with errors that got caught by error validation
        public decimal errorLength;
        public int errorRecordCount;
        public List<DB.RoadInv> errorRecords;

        public ErrorItemBulkModel(DB.roadinvContext _dbContext, decimal aH_BLM, decimal aH_ELM, IQueryable<DB.RoadInv> effectedRecords)
        {
            AH_BLM = aH_BLM;
            AH_ELM = aH_ELM;
            this.bulkDistance = AH_ELM - AH_BLM;

            this.effectedRecords = effectedRecords;

            this.effectedLength = (decimal)this.effectedRecords.Select(x => x.AhLength).Sum();
            this.effectedRecordCount = this.effectedRecords.Count();
            this.effectedBLM = (decimal)this.effectedRecords.Select(x => x.AhLength).Min();
            this.effectedELM = (decimal)this.effectedRecords.Select(x => x.AhLength).Max();

            var errorRecords = new List<DB.RoadInv>();
            foreach (var row in this.effectedRecords)
            {
                ValidationModel.CleanAttr(row);
                var val = new ValidationModel(_dbContext);
                var localErrorList = val.FindErrors(row);
                if (localErrorList.Count > 0)
                {
                    errorRecords.Add(row);
                }
            }

            
            foreach(var row in errorRecords)
            {
                this.errorLength = (decimal)(row.AhLength + errorLength);
            }

            this.errorRecordCount = errorRecords.Count;

        }
    }
}
