using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Models
{
    public class ErrorItemBulkModel
    {
        public decimal bulkDistance;
        public decimal AH_BLM;
        public decimal AH_ELM;
        public decimal AH_Length;
        public IQueryable<DB.RoadInv> effectedRecords;

        public decimal effectedLength;
        public int effectedRecordCount;
        public decimal effectedBLM;
        public decimal effectedELM;

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
