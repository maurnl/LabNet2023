using Northwind.Entities;
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
    public partial class FrmListadoCategories : FrmListadoBase
    {
        public FrmListadoCategories()
        {
            InitializeComponent();
           this.lblTitulo.Text = "Categories";
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            var formAlta = new FrmAbmCategoria();
            if(formAlta.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var logic = new CategoriesLogic();
                    logic.Add(formAlta.CategoriaNueva);
                    ActualizarDatagrid();
                }
                catch (Exception ex)
                {
                    this.lblError.Text = ex.Message;
                }
            }
        }

        public override void ActualizarDatagrid()
        {
            base.ActualizarDatagrid();
            var logic = new CategoriesLogic();
            _bindingSource.DataSource = logic.GetAll();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.SelectedRows.Count == 0)
            {
                return;
            }
            var categoriaSeleccionada = (Categories)dgvListado.SelectedRows[0].DataBoundItem;
            if (categoriaSeleccionada == null)
            {
                return;
            }

            var formAbm = new FrmAbmCategoria(categoriaSeleccionada);
            if (formAbm.ShowDialog() == DialogResult.OK) 
            { 
                try
                {
                    var logic = new CategoriesLogic();
                    logic.Update(categoriaSeleccionada);
                    ActualizarDatagrid();
                    this.lblError.Text = "";
                }
                catch(Exception ex)
                {
                    this.lblError.Text = ex.Message;
                }
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.SelectedRows.Count == 0)
            {
                return;
            }
            var categoriaSeleccionada = (Categories)dgvListado.SelectedRows[0].DataBoundItem;
            if (categoriaSeleccionada == null)
            {
                return;
            }
            if (MessageBox.Show("Esta seguro que desea eliminar la categoria?", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                try
                {
                    var logic = new CategoriesLogic();
                    logic.Delete(categoriaSeleccionada.CategoryID);
                    ActualizarDatagrid();
                }
                catch(Exception ex)
                {
                    this.lblError.Text = ex.Message;
                }
            }
        }
    }
}
