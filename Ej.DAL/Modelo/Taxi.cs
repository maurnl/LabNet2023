using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.DAL.Model
{
    public class Taxi : TransportePublico
    {
        public Taxi(int cantidadPasajeros) : base(cantidadPasajeros)
        {
        }

        public override string Avanzar()
        {
            return $"Apagando luz de disponible y arrancando...";
        }

        public override string Deneterse()
        {
            return $"Encendiendo luz de disponible y deteniendose...";
        }
    }
}
