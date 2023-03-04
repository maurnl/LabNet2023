using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.BLL.Dtos
{
    public class TransporteLecturaDto
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public int CantidadPasajeros { get; set; }
    }
}
