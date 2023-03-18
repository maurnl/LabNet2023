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
        private FrmListadoCustomers _formCustomers;

        public FrmContenedor()
        {
            InitializeComponent();
            this.Text = "Northwind - Practica 4 - LINQ";
            _formProducts = new FrmListadoProducts();
            _formCustomers = new FrmListadoCustomers();
            _formProducts.MdiParent = this;
            _formCustomers.MdiParent = this;
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm("products");
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
