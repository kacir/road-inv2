using RoadInv.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Models
{
    public class SegmentOrderModel
    {

        private DB.roadinvContext _dbContext;

        public SegmentOrderModel(roadinvContext dbContext)
        {
            _dbContext = dbContext;
        }

        //method for finding before and after segments
        public int Before(int sourceID)
        {
            var sourceRecord = this._dbContext.RoadInvs.Find(sourceID);

            var beforeRecords = from record in this._dbContext.RoadInvs 
                       where record.AhRoadId == sourceRecord.AhRoadId & record.AhBlm < sourceRecord.AhBlm 
                       orderby record.AhBlm descending
                                select record;

            var sameBLM = from record in this._dbContext.RoadInvs
                              where record.AhRoadId == sourceRecord.AhRoadId & record.AhBlm == sourceRecord.AhBlm & record.Id < sourceRecord.Id
                          orderby record.Id 
                              select record;

            if (sameBLM.Any())
            {
                return sameBLM.Last().Id;
            } else
            {
                if (beforeRecords.Any())
                {
                    return beforeRecords.First().Id;
                } else
                {
                    return -1;
                }
            }
        }

        public int After(int sourceID)
        {
            var sourceRecord = this._dbContext.RoadInvs.Find(sourceID);

            var afterRecords = from record in this._dbContext.RoadInvs
                               where record.AhRoadId == sourceRecord.AhRoadId & record.AhBlm > sourceRecord.AhBlm
                               select record;

            var sameBLM = from record in this._dbContext.RoadInvs
                          where record.AhRoadId == sourceRecord.AhRoadId & record.AhBlm == sourceRecord.AhBlm & record.Id > sourceRecord.Id
                          orderby record.Id
                          select record;

            if (sameBLM.Any())
            {
                return sameBLM.First().Id;
            } else
            {
                if (afterRecords.Any())
                {
                    return afterRecords.First().Id;
                } else
                {
                    return -1;
                }
                
            }
        }

    }
}
