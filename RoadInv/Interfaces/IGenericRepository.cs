using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RoadInv.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id); //gets the entity by ID
        IEnumerable<T> GetAll(); //gets all the records
        IEnumerable<T> Find(Expression<Func<T, bool>> expression); //finds a set of records that match a passed expression
        void Add(T entity); //adds a record
        void AddRange(IEnumerable<T> entities); //adds a list of records
        void Remove(T entity); //removes a record from the context
        void RemoveRange(IEnumerable<T> entities); //removes a list of records
    }
}
