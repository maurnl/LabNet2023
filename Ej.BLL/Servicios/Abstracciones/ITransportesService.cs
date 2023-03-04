﻿using Ej.BLL.Dtos;
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
        void CrearTransporte(TransporteCrearDto transporte);
        string AvanzarTransporte(int idTransporte);
        string DetenerTransporte(int idTransporte);
        List<TransporteLecturaDto> ObtenerTransportes();
    }
}
