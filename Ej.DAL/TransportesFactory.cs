using Ej.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.DAL
{
    public class TransportesFactory
    {
        public TransportePublico CrearTransporte(TipoTransporte tipoTransporte, int cantidadPasajeros)
        {
            switch(tipoTransporte)
            {
                case TipoTransporte.Omnibus:
                    return new Omnibus(cantidadPasajeros);
                case TipoTransporte.Taxi:
                    return new Taxi(cantidadPasajeros);
                default:
                    throw new ArgumentException(nameof(tipoTransporte));
            }
        }
    }
}
