using System.Linq;

namespace Northwind.Data.Abstractions
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll(string includeProperties = "");

        T FindById(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void SaveChanges();
    }
}
