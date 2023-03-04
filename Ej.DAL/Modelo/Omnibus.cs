using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.DAL.Model
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int cantidadPasajeros) : base(cantidadPasajeros)
        {
        }

        public override string Avanzar()
        {
            return $"Cerrando las puertas y avanzando...";
        }

        public override string Deneterse()
        {
            return $"Deteniendose y abriendo puertas...";
        }
    }
}
