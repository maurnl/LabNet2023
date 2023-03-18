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
        protected Dictionary<string, Action> _filtros;

        public FrmListadoBase()
        {
            InitializeComponent();
            this.Text = "Listado";
            _bindingSource = new BindingSource();
            this.dgvListado.DataSource = _bindingSource;
            this.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
            this.lblError.Text = "";
            _filtros = new Dictionary<string, Action>();
            this.cboListados.DataSource = _filtros.Keys.ToList();
            this.cboListados.DropDownStyle = ComboBoxStyle.DropDownList;
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

        public void ActualizarFuenteCombobox()
        {
            this.cboListados.DataSource = null;
            this.cboListados.DataSource = _filtros.Keys.ToList();
        }

        public virtual void ActualizarDatagrid()
        {
            _bindingSource.ResetBindings(false);
            PintarFilas();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AplicarFiltro(cboListados.SelectedItem.ToString());
        }

        protected void AplicarFiltro(string nombre)
        {
            if(_filtros.TryGetValue(nombre, out Action filtro))
            {
                filtro?.Invoke();
            }
        }
    }
}
