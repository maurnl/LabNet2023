using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.BLL.Excepciones
{
    public class PresionasteBotonRojoException : Exception
    {
        public PresionasteBotonRojoException() : base("Como vas a presionar un boton rojo?!?!")
        {

        }
    }
}
