using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Models
{
    /*
    The main Math class
    Contains all methods for performing basic math functions
*/
    /// <summary>
    /// contains class for performing bulk edits on roadway inventory data
    /// </summary>
    /// <remarks>
    /// This class can BulkEdit and nothing else
    /// </remarks>
    /// <returns>
    /// 
    /// </returns>
    public class BulkEditModel
    {
        public DB.roadinvContext _dbContext;
        public BulkEditModel(RoadInv.DB.roadinvContext RoadInvContext)
        {
            this._dbContext = RoadInvContext;
        }

        /// <summary>
        /// Performs a bulk edit logmile ajustment operation of the specified range of records
        /// </summary>
        /// <param name="AH_RoadID">the ARNOLD road id for the record </param>
        /// <param name="AH_BLM">the ARNOLD begining logmile</param>
        /// <param name="AH_ELM">the ARNOLD ending logmile</param>
        /// <returns>
        /// a linq queryable object containing only the records within the specificed into BLM and ELM
        /// </returns>
        public IQueryable<DB.RoadInv> BulkEdit(string AH_RoadID, decimal? AH_BLM, decimal? AH_ELM)
        {

            decimal[] spliterLogmileList = {AH_BLM.Value, AH_ELM.Value };

            foreach(var splitLogmile in spliterLogmileList)
            {
                var splitterRecords = from record in this._dbContext.RoadInvs 
                                      where record.AhRoadId == AH_RoadID & splitLogmile > record.AhBlm & record.AhElm > splitLogmile 
                                      select record;

                bool changesOccured = false;
                foreach(var record in splitterRecords)
                {
                    var newRecord = ErrorItemBulkModel.CloneSegment(record);
                    record.AhElm = splitLogmile;
                    newRecord.AhBlm = splitLogmile;
                    this._dbContext.RoadInvs.Add(newRecord);
                    changesOccured = true;
                }
                if (changesOccured)
                {
                    this._dbContext.SaveChanges();
                }
            }
            
            //find records that are 100% inside the bulk segment
            var interiorSegments = from record in this._dbContext.RoadInvs
                                   where record.AhRoadId == AH_RoadID & (record.AhBlm >= AH_BLM & record.AhElm > AH_BLM) & (record.AhBlm < AH_ELM & record.AhElm <= AH_ELM)
                                   select record;

            if (!interiorSegments.Any())
            {
                throw new Exception("No records inside of range");
            }

            return interiorSegments;
        }
    }
}
