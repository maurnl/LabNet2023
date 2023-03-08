using Ej.BLL.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.BLL
{
    public static class Logic
    {
        public static void LanzarExcepcion()
        {
            throw new InvalidOperationException();
        }

        public static void LanzarExcepcionPersonalizada()
        {
            throw new PresionasteBotonRojoException();
        }
    }
}
