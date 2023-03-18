using Northwind.Entities;
using Northwind.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.UI
{
    public partial class FrmListadoProducts : FrmListadoBase
    {
        public FrmListadoProducts()
        {
            InitializeComponent();
            this.lblTitulo.Text = "Productos";
            this._filtros.Add("Todos", ListarTodos);
            this._filtros.Add("Sin Stock", ListarProductosSinStock);
            this._filtros.Add("En stock y cuestan mas de tres por unidad", ListarProductosEnStockYCuestanMasDeTres);
            this._filtros.Add("Ordenados por nombre ascendente", ListarProductosOrdenadosPorNombre);
            this._filtros.Add("Ordenados por stock descendente", ListarProductosOrdenadosPorStockDescendente);
            this._filtros.Add("Primer elemento", ListarPrimerElementoDeProductos);
            this._filtros.Add("Primero o nulo con ID 789    ", ListarPrimerElementoDeProductos);
            this._filtros.Add("Categorias de los productos", ListarCategoriasDeLosProductos);
            ActualizarFuenteCombobox();
        }

        private void FrmListadoProducts_Load(object sender, EventArgs e)
        {
            ListarTodos();
        }

        public void ListarTodos()
        {
            var logic = new ProductsLogic();
            _bindingSource.DataSource = (from product in logic.GetAll()
                                         select product).ToList();
        }

        public void ListarProductosSinStock()
        {
            var logic = new ProductsLogic();
            _bindingSource.DataSource = logic.GetAll().Where(p => p.UnitsInStock == 0).ToList();
        }
        public void ListarProductosEnStockYCuestanMasDeTres()
        {
            var logic = new ProductsLogic();
            _bindingSource.DataSource = (from product in logic.GetAll()
                                        where product.UnitsInStock > 0 && product.UnitPrice > 3
                                        select product).ToList();
        }

        public void ListarProductosOrdenadosPorNombre()
        {
            var logic = new ProductsLogic();
            _bindingSource.DataSource = logic.GetAll().OrderBy(p => p.ProductName).ToList();
        }

        public void ListarProductosOrdenadosPorStockDescendente()
        {
            var logic = new ProductsLogic();
            _bindingSource.DataSource = (from product in logic.GetAll()
                                         where product.UnitsInStock > 0
                                         orderby product.UnitsInStock descending
                                         select product).ToList();
        }

        public void ListarPrimerElementoDeProductos()
        {
            var logic = new ProductsLogic();
            _bindingSource.DataSource = logic.GetAll().FirstOrDefault();
        }

        public void PrimeroONuloConId789()
        {
            var logic = new ProductsLogic();

            var elemento = (from product in logic.GetAll()
                            where product.ProductID == 789
                            select product).FirstOrDefault();

            if(elemento == null)
            {
                MessageBox.Show("El elemento fue nulo", "Advertencia", MessageBoxButtons.OK);
                return;
            }

            _bindingSource.DataSource = elemento;
        }

        public void ListarCategoriasDeLosProductos()
        {
            var productsLogic = new ProductsLogic();
            var categoriesLogic = new CategoriesLogic();

            var query = productsLogic.GetAll().Join(categoriesLogic.GetAll(),
                producto => producto.CategoryID.Value,
                categoria => categoria.CategoryID,
                (producto, categoria) => new
                {
                    producto.ProductID,
                    producto.ProductName,
                    categoria.CategoryName,
                    categoria.Description
                });

            _bindingSource.DataSource = query.ToList();
        }
    }
}
