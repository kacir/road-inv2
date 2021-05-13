using RoadInv.Interfaces;
using RoadInv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DB.roadinvContext _context;
        public UnitOfWork(DB.roadinvContext context)
        {
            _context = context;
            Roads = new RoadinvRepository(_context);
        }
        public IRoadinvRepository Roads { get; set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
