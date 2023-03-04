using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.DAL.Model
{
    public abstract class TransportePublico
    {
        public int Id { get; set; }
        public int CantidadPasajeros { get; private set; }

        public TransportePublico(int cantidadPasajeros)
        {
            CantidadPasajeros = cantidadPasajeros;
        }


        public abstract string Avanzar();
        public abstract string Deneterse();
    }
}
