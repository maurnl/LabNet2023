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
        private static int s_id;
        private static readonly List<TransportePublico> s_transportes;

        static RepoTransportesEnMemoria()
        {
            s_transportes = new List<TransportePublico>();
            s_id = 1;
        }

        public void Agregar(TransportePublico transporte)
        {
            transporte.Id = s_id++;
            s_transportes.Add(transporte);
        }

        public List<TransportePublico> ObtenerTodos()
        {
            return s_transportes;
        }
    }
}
