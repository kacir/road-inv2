using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Interfaces
{
    public interface IRoadinvRepository : IGenericRepository<DB.RoadInv>
    {
        IEnumerable<DB.RoadInv> GetNHSRoads();
    }
}
