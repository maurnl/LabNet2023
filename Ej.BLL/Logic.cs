using Ej.BLL.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.BLL
{
    public class Logic
    {
        public void LanzarExcepcion()
        {
            throw new InvalidOperationException();
        }

        public void LanzarExcepcionPersonalizada()
        {
            throw new PresionasteBotonRojoException();
        }
    }
}
