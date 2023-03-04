using Ej.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej.PLL
{
    public partial class FrmNuevoTransporte : Form
    {
        public TransporteCrearDto NuevoTransporte { get; private set; }

        public FrmNuevoTransporte()
        {
            InitializeComponent();
            cboTipo.DataSource = Enum.GetNames(typeof(TipoTransporte));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoTransporte = new TransporteCrearDto
            {
                Tipo = (TipoTransporte)Enum.Parse(typeof(TipoTransporte), cboTipo.SelectedItem.ToString()),
                CantidadPasajeros = (int)nudCantidadPasajeros.Value
            };
            DialogResult = DialogResult.OK;
        }
    }
}
