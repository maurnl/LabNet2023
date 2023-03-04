using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.DAL.Model
{
    public abstract class TransportePublico
    {
        public TransportePublico(int cantidadPasajeros)
        {
            CantidadPasajeros = cantidadPasajeros;
        }

        public int CantidadPasajeros { get; private set; }

        public abstract string Avanzar();
        public abstract string Deneterse();
    }
}
