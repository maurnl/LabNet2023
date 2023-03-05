using Ej.BLL.Dtos;
using Ej.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.BLL.Validaciones
{
    public static class ValidadorTransportes
    {
        public static void ValidarTransporte(TransporteCrearDto transporte)
        {
            if (transporte == null)
            {
                throw new ArgumentNullException(nameof(transporte));
            }

            switch(transporte.Tipo)
            {
                case TipoTransporte.Omnibus:
                    ValidarOmnibus(transporte);
                    break;
                case TipoTransporte.Taxi:
                    ValidarTaxi(transporte);
                    break;
            }
        }

        private static void ValidarTaxi(TransporteCrearDto taxi)
        {
            if(taxi.CantidadPasajeros > 4)
            {
                throw new TaxiLlenoException("Un taxi solo puede llevar hasta 4 personas!");
            }
        }

        private static void ValidarOmnibus(TransporteCrearDto omnibus)
        {
            if (omnibus.CantidadPasajeros > 100)
            {
                throw new OmnibusLlenoException("Un omnibus tiene capacidad para 100 personas o menos!");
            }
        }
    }
}
