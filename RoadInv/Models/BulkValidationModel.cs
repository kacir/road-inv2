using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Models
{
    public class BulkValidationModel
    {
        private ValidationModel validator;
        private DB.roadinvContext _dbContext;

        public BulkValidationModel(DB.roadinvContext dbContext)
        {
            this._dbContext = dbContext;
            this.validator = new ValidationModel(dbContext);
        }


        public void BulkValidate()
        {
            Dictionary<int, int> errorCounts = new();
            Dictionary<int, DB.RoadInv> errorRecords = new();

            foreach (var record in _dbContext.RoadInvs)
            {
                var errors = this.validator.FindErrors(record);
            }
        }
    }

}
