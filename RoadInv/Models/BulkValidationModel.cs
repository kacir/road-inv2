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

        public List<BulkValidationItemModel> masterList = new List<BulkValidationItemModel>();

        public BulkValidationModel(DB.roadinvContext dbContext)
        {
            this._dbContext = dbContext;
            this.validator = new ValidationModel(dbContext);
        }


        public void BulkValidate()
        {
            foreach (var record in _dbContext.RoadInvs.OrderBy(record => record.AhRoadId))
            {
                var errors = this.validator.FindErrors(record);
                if (errors.Count > 0)
                {
                    var item = new BulkValidationItemModel
                    {
                        errors = errors,
                        segment = record
                    };
                    masterList.Add(item);
                }
                if (masterList.Count > 3000)
                {
                    break;
                }
            }
        }
    }

}
