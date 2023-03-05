using System;
using System.Runtime.Serialization;

namespace Ej.BLL.Validaciones
{
    public class TaxiLlenoException : Exception
    {
        public TaxiLlenoException()
        {
        }

        public TaxiLlenoException(string message) : base(message)
        {
        }
    }
}