using Northwind.Data.Abstractions;
using System;
using System.Data.Entity;
using System.Linq;

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

        public T FindById(int id)
        {
            return _nwContext.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll(string includeProperties = "")
        {
            IQueryable<T> query = _nwContext.Set<T>();
            foreach (var includeProperty in includeProperties.Split
            (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
            return query.AsQueryable() ?? Enumerable.Empty<T>().AsQueryable();
        }

        public void SaveChanges()
        {
            _nwContext.SaveChanges();
        }
    }
}
