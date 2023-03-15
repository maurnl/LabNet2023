using Northwind.Data;
using Northwind.Data.Abstractions;
using Northwind.Entities;
using Northwind.Logic.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Logic
{
    public class SuppliersLogic : IEnumAllLogic<Suppliers>
    {
        private readonly IGenericRepository<Suppliers> _suppliersRepo;

        public SuppliersLogic()
        {
            _suppliersRepo = new GenericRepository<Suppliers>();
        }

        public IEnumerable<Suppliers> GetAll()
        {
            return _suppliersRepo.GetAll(includeProperties: "Products").ToList();
        }
    }
}
