using Northwind.Data;
using Northwind.Data.Abstractions;
using Northwind.Entities;
using Northwind.Logic.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Logic
{
    public class ProductsLogic : IEnumAllLogic<Products>
    {
        private readonly IGenericRepository<Products> _productsRepo;

        public ProductsLogic()
        {
            _productsRepo = new GenericRepository<Products>();
        }

        public IEnumerable<Products> GetAll()
        {
            return _productsRepo.GetAll().ToList();
        }
    }
}
