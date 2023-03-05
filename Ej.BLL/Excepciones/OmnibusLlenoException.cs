using System;
using System.Runtime.Serialization;

namespace Ej.BLL.Validaciones
{
    public class OmnibusLlenoException : Exception
    {
        public OmnibusLlenoException()
        {
        }

        public OmnibusLlenoException(string message) : base(message)
        {
        }
    }
}