using Ej.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.DAL.Abstracciones
{
    public interface ITransportesRepository
    {
        void Agregar(TransportePublico transporte);
        List<TransportePublico> ObtenerTodos();
        TransportePublico ObtenerPorId(int id);
    }
}
