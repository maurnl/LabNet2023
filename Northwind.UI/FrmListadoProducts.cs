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
        }

        private void FrmListadoProducts_Load(object sender, EventArgs e)
        {
            var logic = new ProductsLogic();
            _bindingSource.DataSource = logic.GetAll();
        }
    }
}
