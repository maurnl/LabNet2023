using Ej.DAL.Abstracciones;
using Ej.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.DAL
{
    public class RepoTransportesEnMemoria : ITransportesRepository
    {
        private static List<TransportePublico> _transportes;

        static RepoTransportesEnMemoria()
        {
            _transportes = new List<TransportePublico>();
        }

        public void Agregar(TransportePublico transporte)
        {
            _transportes.Add(transporte);
        }

        public List<TransportePublico> ObtenerTodos()
        {
            return _transportes;
        }
    }
}
