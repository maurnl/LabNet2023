using Ej.BLL.Dtos;
using Ej.BLL.Servicios;
using Ej.DAL.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej.PLL.Forms
{
    public partial class FrmPrincipal : Form
    {
        private BindingSource _fuenteDatos;
        private readonly ITransportesService _transportesService;

        public FrmPrincipal()
        {
            InitializeComponent();
            _fuenteDatos = new BindingSource();
            btnAvanzar.Enabled = false;
            btnDetener.Enabled = false; 
        }

        public FrmPrincipal(ITransportesService transportesService) : this()
        {
            _transportesService = transportesService;
            ActualizarListado();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            if(dgvTransportes.SelectedRows.Count == 0)
            {
                return;
            }
            var transporteSeleccionado = (TransporteLecturaDto)dgvTransportes.SelectedRows[0].DataBoundItem;
            if (transporteSeleccionado == null)
            {
                return;
            }
            string resultado = _transportesService.AvanzarTransporte(transporteSeleccionado.Id);
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var formDialogo = new FrmNuevoTransporte();
            if(formDialogo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _transportesService.CrearTransporte(formDialogo.NuevoTransporte);
                }catch(FlotaLlenaException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                btnAvanzar.Enabled = true;
                btnDetener.Enabled = true;
                ActualizarListado();
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            var transporteSeleccionado = (TransporteLecturaDto)dgvTransportes.SelectedRows[0].DataBoundItem;
            if(transporteSeleccionado == null )
            {
                return;
            }
            string resultado = _transportesService.DetenerTransporte(transporteSeleccionado.Id);
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ActualizarListado()
        {
            var transportes = _transportesService.ObtenerTransportes();
            if(transportes.Count > 0)
            {
                dgvTransportes.Visible = true;
                lblPlaceholder.Visible = false;
                _fuenteDatos.DataSource = transportes;
                _fuenteDatos.ResetBindings(false);
                dgvTransportes.DataSource = transportes;
            }
            else
            {
                dgvTransportes.Visible = false;
            }
        }
    }
}
