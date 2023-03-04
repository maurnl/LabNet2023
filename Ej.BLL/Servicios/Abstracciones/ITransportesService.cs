using Ej.BLL.Dtos;
using Ej.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.DAL.Services.Abstractions
{
    public interface ITransportesService
    {
        TransportePublico CrearTransporte(TransporteCrearDto transporte);
    }
}
