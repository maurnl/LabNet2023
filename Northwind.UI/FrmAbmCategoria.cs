using Northwind.Entities;
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
    public partial class FrmAbmCategoria : Form
    {
        private bool _esEditar;
        private Categories _categoriaNueva;
        private Categories _categoriaEditada;
        public Categories CategoriaNueva { get => _categoriaNueva; }
        public FrmAbmCategoria()
        {
            InitializeComponent();
            this.txtId.Enabled = false;
            this.txtId.Text = "Nueva categoria...";
            this.lblError.Text = "";
        }

        public FrmAbmCategoria(Categories categoria) : this()
        {
            _esEditar = true;
            _categoriaEditada = categoria;
            this.lblTitulo.Text = "Editar categoria";
            this.txtNombre.Text = _categoriaEditada.CategoryName;
            this.txtDescripcion.Text = _categoriaEditada.Description;
            this.txtId.Text = _categoriaEditada.CategoryID.ToString();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(_esEditar)
                {
                    _categoriaEditada.Description = this.txtDescripcion.Text;
                    _categoriaEditada.CategoryName = this.txtNombre.Text;
                }
                else
                {
                    _categoriaNueva = new Categories
                    {
                        CategoryName = this.txtNombre.Text,
                        Description = this.txtDescripcion.Text
                    };
                    this.lblError.Text = "";
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.lblError.Text = ex.Message;
            }
        }
    }
}
