using Northwind.Data.Abstractions;
using Northwind.Data;
using Northwind.Entities;
using Northwind.Logic.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Logic
{
    public class OrdersLogic : IEnumAllLogic<Orders>
    {
        private readonly IGenericRepository<Orders> _ordersRepo;

        public OrdersLogic()
        {
            _ordersRepo = new GenericRepository<Orders>();
        }

        public IEnumerable<Orders> GetAll()
        {
            return _ordersRepo.GetAll();
        }
    }
}
