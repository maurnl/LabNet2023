using System;
using System.Runtime.Serialization;

namespace Ej.BLL.Servicios
{
    public class FlotaLlenaException : Exception
    {
        public FlotaLlenaException()
        {
        }

        public FlotaLlenaException(string message) : base(message)
        {
        }
    }
}