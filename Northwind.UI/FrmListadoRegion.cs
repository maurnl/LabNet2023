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
    public partial class FrmListadoRegion : FrmListadoBase
    {
        public FrmListadoRegion()
        {
            InitializeComponent();
            this.lblTitulo.Text = "Regiones";
        }

        private void FrmListadoRegion_Load(object sender, EventArgs e)
        {
            var logic = new RegionLogic();
            _bindingSource.DataSource = logic.GetAll();
        }
    }
}
