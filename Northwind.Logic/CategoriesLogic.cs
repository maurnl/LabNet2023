using System;
using Northwind.Data;
using Northwind.Data.Abstractions;
using Northwind.Entities;
using Northwind.Logic.Abstractions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Logic
{
    public class CategoriesLogic : IABMLogic<Categories>, IEnumAllLogic<Categories>
    {
        private readonly IGenericRepository<Categories> _categoriesRepo;

        public CategoriesLogic()
        {
            _categoriesRepo = new GenericRepository<Categories>();
        }

        public CategoriesLogic(IGenericRepository<Categories> categoriesRepo)
        {
            _categoriesRepo = categoriesRepo;
        }

        public IEnumerable<Categories> GetAll()
        {
            return _categoriesRepo.GetAll().ToList();
        }

        public void Add(Categories newEntity)
        {
            _categoriesRepo.Add(newEntity);
            _categoriesRepo.SaveChanges();
        }

        public void Delete(int id)
        {
            var categoryToDelete = _categoriesRepo.FindById(id);

            if (categoryToDelete == null)
            {
                throw new ArgumentException($"No se pudo encontrar la categoria id {id}", nameof(categoryToDelete));
            }

            _categoriesRepo.Delete(categoryToDelete);
            _categoriesRepo.SaveChanges();
        }

        public void Update(Categories category)
        {
            var categoryToUpdate = _categoriesRepo.FindById(category.CategoryID);

            if (categoryToUpdate == null)
            {
                throw new ArgumentException($"No se pudo encontrar la region id {category.CategoryID}", nameof(categoryToUpdate));
            }

            categoryToUpdate.CategoryName = category.CategoryName;

            categoryToUpdate.Description = category.Description;
            _categoriesRepo.SaveChanges();
        }
    }
}
