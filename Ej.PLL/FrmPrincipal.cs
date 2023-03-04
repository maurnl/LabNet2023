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
        private readonly ITransportesService _transportesService;

        public FrmPrincipal()
        {
            InitializeComponent();

        }

        public FrmPrincipal(ITransportesService transportesService) : base()
        {
            _transportesService = transportesService;
        }
    }
}
