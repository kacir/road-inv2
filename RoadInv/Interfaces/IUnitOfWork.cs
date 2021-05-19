using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRoadinvRepository Roads { get; }
        int Complete();
    }
}
