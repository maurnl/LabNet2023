using Ej.BLL;
using Ej.BLL.Excepciones;
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
    public partial class FrmPrincipal : Form
    {
        private readonly Calculadora _calculadora;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.lblError.Text = string.Empty;
            this.lblResultado.Text = string.Empty;
            this.lblErrorExcepciones.Text = string.Empty;
            this.Text = "Practica 2";
        }

        public FrmPrincipal(Calculadora calcu) : this()
        {
            _calculadora = calcu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string dividendo = this.txtDividendo.Text;
                string divisor = this.txtDivisor.Text;

                dividendo.LanzarSiEsCadenaVaciaONula();
                dividendo.LanzarSiNoEsTodaNumerica();

                int resultado = _calculadora.Dividir(int.Parse(dividendo), int.Parse(divisor));
                this.lblResultado.Text = $"El resultado es: {resultado}";
                this.lblError.Text = string.Empty;
            }catch(DivideByZeroException ex)
            {
                this.lblError.Text = $"Solo Messi mi capitan puede dividir por cero! {ex.Message}";
            }catch(ArgumentException ex)
            {
                this.lblError.Text = ex.Message;
            }catch(Exception ex)
            {
                this.lblError.Text = $"Error inesperado: {ex.Message}";
            }
        }

        private void btnBotonRojo_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.LanzarExcepcionPersonalizada();
            }catch(PresionasteBotonRojoException ex )
            {
                this.lblErrorExcepciones.Text = $"Mensaje: {ex.Message}. Tipo: {ex.GetType()}"; 
            }
        }

        private void btnExcepcion_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.LanzarExcepcion();
            }
            catch (InvalidOperationException ex)
            {
                this.lblErrorExcepciones.Text = $"Mensaje: {ex.Message}. Tipo: {ex.GetType()}";
            }
        }
    }
}
