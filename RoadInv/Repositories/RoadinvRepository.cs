using RoadInv.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Repositories
{
    public class RoadinvRepository : GenericRepository<DB.RoadInv>, IRoadinvRepository
    {
        public RoadinvRepository(DB.roadinvContext context) : base(context)
        {
        }
        public IEnumerable<DB.RoadInv> GetNHSRoads() //pending implementation (not sure we even need this layer of abstraction. DbContext is already a unit of work)
        {
            return _context.RoadInvs.OrderByDescending(r => r.Nhs != "0").ToList();
        }

    }
}
