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
    public class CustomersLogic : IEnumAllLogic<Customers>
    {
        private readonly IGenericRepository<Customers> _customersRepo;

        public CustomersLogic() 
        {
            _customersRepo = new GenericRepository<Customers>();
        }

        public IEnumerable<Customers> GetAll()
        {
            return _customersRepo.GetAll(includeProperties: "Orders").ToList();
        }
    }
}
