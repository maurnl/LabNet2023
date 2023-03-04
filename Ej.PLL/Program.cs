using Ej.BLL.Servicios;
using Ej.DAL;
using Ej.PLL.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej.PLL
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var repo = new RepoTransportesEnMemoria();
            var formPrincipal = new FrmPrincipal(new TransportesService(repo));
            Application.Run(formPrincipal);
        }
    }
}
