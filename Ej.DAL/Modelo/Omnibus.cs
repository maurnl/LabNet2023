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
            throw new NotImplementedException();
        }

        public override string Deneterse()
        {
            throw new NotImplementedException();
        }
    }
}
