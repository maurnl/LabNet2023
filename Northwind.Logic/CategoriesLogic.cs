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
    public class CategoriesLogic : IEnumAllLogic<Categories>
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
    }
}