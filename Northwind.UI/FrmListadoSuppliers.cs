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
    public partial class FrmListadoSuppliers : FrmListadoBase
    {
        public FrmListadoSuppliers()
        {
            InitializeComponent();
            this.lblTitulo.Text = "Suppliers";
        }

        private void FrmListadoSuppliers_Load(object sender, EventArgs e)
        {
            var logic = new SuppliersLogic();
            _bindingSource.DataSource = logic.GetAll();
        }
    }
}
