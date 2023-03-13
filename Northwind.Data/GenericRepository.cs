using Northwind.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly NorthwindContext _nwContext;

        public GenericRepository()
        {
            _nwContext = new NorthwindContext();
        }

        public void Add(T entity)
        {
            _nwContext.Set<T>().Add(entity);
            _nwContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _nwContext.Entry(entity).State = EntityState.Modified;
            _nwContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _nwContext.Set<T>().Remove(entity);
            _nwContext.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return _nwContext.Set<T>().AsQueryable() ?? Enumerable.Empty<T>().AsQueryable();
        }
    }
}
