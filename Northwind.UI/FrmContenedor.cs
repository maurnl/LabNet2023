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
    public partial class FrmContenedor : Form
    {
        private FrmListadoBase _formActivo;
        private FrmListadoProducts _formProducts;
        private FrmListadoRegion _formRegions;
        private FrmListadoCategories _formCategories;
        private FrmListadoSuppliers _formSuppliers;
        private FrmListadoCustomers _formCustomers;

        public FrmContenedor()
        {
            InitializeComponent();
            this.Text = "Northwind - Practica 3";
            _formProducts = new FrmListadoProducts();
            _formCategories = new FrmListadoCategories();
            _formSuppliers = new FrmListadoSuppliers();
            _formRegions = new FrmListadoRegion();
            _formCustomers = new FrmListadoCustomers();
            _formProducts.MdiParent = this;
            _formRegions.MdiParent = this;
            _formCategories.MdiParent = this;
            _formSuppliers.MdiParent = this;
            _formCustomers.MdiParent = this;
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm("products");
        }
        private void verToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarForm("regions");
        }

        private void verToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MostrarForm("categories");
        }
        private void verToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MostrarForm("suppliers");

        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm("customers");
        }

        private void MostrarForm(string nombre)
        {
            FrmListadoBase formAMostrar;
            switch (nombre)
            {
                case "viajes":
                    formAMostrar = _formProducts;
                    break;
                case "regions":
                    formAMostrar = _formRegions;
                    break;
                case "categories":
                    formAMostrar = _formCategories;
                    break;
                case "suppliers":
                    formAMostrar = _formSuppliers;
                    break;
                case "customers":
                    formAMostrar = _formCustomers;
                    break;
                default:
                    formAMostrar = _formProducts;
                    break;
            }
            _formActivo = formAMostrar;
            formAMostrar.Show();
            formAMostrar.Activate();
            formAMostrar.ActualizarDatagrid();
        }
    }
}
