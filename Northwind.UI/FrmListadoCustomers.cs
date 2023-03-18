using Northwind.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.UI
{
    public partial class FrmListadoCustomers : FrmListadoBase
    {
        public FrmListadoCustomers()
        {
            InitializeComponent();
            _filtros.Add("Listar todos", ListarTodos);
            _filtros.Add("Clientes de la region WA", ListarCustomersDeWA);
            _filtros.Add("Nombre de clientes en mayuscula", ListarNombresDeLosClientesEnMayus);
            _filtros.Add("Nombre de clientes en minuscula", ListarNombresDeLosClientesEnMinus);
            _filtros.Add("Join clientes y ordenes de la region WA y fecha mayor a 1/1/1997", JoinClientesYOrdenesDeWa);
            _filtros.Add("Listar primeros tres de la region WA", ListarPrimerosTresDeWa);
            _filtros.Add("Listar clientes con cantidad de ordenes", ListarClientesConCantidaDeOrdenes);
            ActualizarFuenteCombobox();
        }

        private void FrmListadoCustomers_Load(object sender, EventArgs e)
        {
            ActualizarDatagrid();
        }

        public override void ActualizarDatagrid()
        {
            base.ActualizarDatagrid();
            var logic = new CustomersLogic();
            _bindingSource.DataSource = logic.GetAll();
        }

        public void ListarTodos()
        {
            var logic = new CustomersLogic();
            _bindingSource.DataSource = (from product in logic.GetAll()
                                         select product).ToList();
        }

        public void ListarCustomersDeWA()
        {
            var logic = new CustomersLogic();
            _bindingSource.DataSource = logic.GetAll().Where(c => c.Region == "WA");
        }

        public void ListarNombresDeLosClientesEnMayus()
        {
            var logic = new CustomersLogic();
            var query = (from customer in logic.GetAll()
                         select customer);

            var todosMayuscula = query.Select(c => new { Id = c.CustomerID, Nombre = c.ContactName.ToUpperInvariant() }).ToList();
            _bindingSource.DataSource = todosMayuscula;
        }

        public void ListarNombresDeLosClientesEnMinus()
        {
            var logic = new CustomersLogic();
            var query = (from customer in logic.GetAll()
                         select customer);

            var todosMinuscula = query.Select(c => new { Id = c.CustomerID, Nombre = c.ContactName.ToLowerInvariant() }).ToList();
            _bindingSource.DataSource = todosMinuscula;
        }
        
        public void JoinClientesYOrdenesDeWa()
        {
            var customersLogic = new CustomersLogic();
            var ordersLogic = new OrdersLogic();

            var lista = (from customer in customersLogic.GetAll()
                         join order in ordersLogic.GetAll()
                         on customer.CustomerID equals order.CustomerID
                         where order.OrderDate >= DateTime.Parse("1/1/1997")
                         select new { customer.CustomerID,
                                      CustomerName = customer.ContactName,
                                      order.OrderID,
                                      order.Freight,
                                      order.OrderDate,}).ToList();

            _bindingSource.DataSource = lista;  
        }

        public void ListarPrimerosTresDeWa()
        {
            var logic = new CustomersLogic();

            var lista = logic.GetAll().Where(c => c.Region == "WA").Take(3).ToList();

            _bindingSource.DataSource = lista;
        }

        public void ListarClientesConCantidaDeOrdenes()
        {
            var customersLogic = new CustomersLogic();

            var query = (from customer in customersLogic.GetAll()
                         orderby customer.Orders.Count descending
                         select new
                         {
                             customer.CustomerID,
                             CustomerName = customer.ContactName,
                             CantidadOrdenes = customer.Orders.Count
                         });

            _bindingSource.DataSource = query.ToList();
        }
    }
}
