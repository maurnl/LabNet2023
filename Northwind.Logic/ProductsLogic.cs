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
    public class ProductsLogic : IABMLogic<Products>, IEnumAllLogic<Products>
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

        public void Add(Products newEntity)
        {
            _productsRepo.Add(newEntity);
            _productsRepo.SaveChanges();
        }
        public void Update(Products entity)
        {
            _productsRepo.Update(entity);
            _productsRepo.SaveChanges();
        }

        public void Delete(int id)
        {
            var productToDelete = _productsRepo.FindById(id);
            if(productToDelete == null)
            {
                throw new ArgumentException("Producto no encontrado", nameof(productToDelete));
            }

            _productsRepo.Delete(productToDelete);
            _productsRepo.SaveChanges();
        }
    }
}
