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
    public partial class FrmListadoBase : Form
    {
        protected BindingSource _bindingSource;

        public FrmListadoBase()
        {
            InitializeComponent();
            this.Text = "Listado";
            _bindingSource = new BindingSource();
            this.dgvListado.DataSource = _bindingSource;
            this.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
            this.lblError.Text = "";
        }

        protected virtual void PintarFilas()
        {
            if (this.dgvListado.DataSource == null)
            {
                return;
            }

            for (int i = 0; i < this.dgvListado.RowCount; i++)
            {
                DataGridViewRow filaActual = this.dgvListado.Rows[i];
                {
                    if (i % 2 == 0)
                    {
                        filaActual.DefaultCellStyle.BackColor = Color.LightGray;
                    }
                }
            }
        }

        public virtual void ActualizarDatagrid()
        {
            _bindingSource.ResetBindings(false);
            PintarFilas();
        }
    }
}
