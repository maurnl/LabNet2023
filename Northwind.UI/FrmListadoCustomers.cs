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
    public partial class FrmListadoCustomers : FrmListadoBase
    {
        public FrmListadoCustomers()
        {
            InitializeComponent();
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


    }
}
