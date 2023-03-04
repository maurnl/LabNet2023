using Ej.BLL.Dtos;
using Ej.DAL;
using Ej.DAL.Abstracciones;
using Ej.DAL.Model;
using Ej.DAL.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.BLL.Servicios
{
    public class TransportesService : ITransportesService
    {
        private readonly ITransportesRepository _transportesRepo;

        public TransportesService(ITransportesRepository transportesRepo)
        {
            _transportesRepo = transportesRepo;
        }

        public void CrearTransporte(TransporteCrearDto transporte)
        {
            if(_transportesRepo.ObtenerTodos().Count >= 10)
            {
                throw new FlotaLlenaException("No hay mas espacio para transportes! (MAX. 10)");
            }
            var transporteMapeado = new TransportesFactory().CrearTransporte(transporte.Tipo, transporte.CantidadPasajeros);
            _transportesRepo.Agregar(transporteMapeado);
        }

        public string AvanzarTransporte(int idTransporte)
        {
            var transporte = _transportesRepo.ObtenerPorId(idTransporte);
            return transporte.Avanzar();
        }


        public string DetenerTransporte(int idTransporte)
        {
            var transporte = _transportesRepo.ObtenerPorId(idTransporte);
            return transporte.Deneterse();
        }

        public List<TransporteLecturaDto> ObtenerTransportes()
        {
            return _transportesRepo.ObtenerTodos().Select(t => new TransporteLecturaDto
            {
                Id = t.Id,
                Tipo = t.GetType().Name,
                CantidadPasajeros = t.CantidadPasajeros
            }).ToList();
        }
    }
}
