using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.BLL
{
    public static class ExtensionesString
    {
        public static void LanzarSiNoEsTodaNumerica(this string cadena)
        {
            foreach (char caracter in cadena)
            {
                if(!char.IsDigit(caracter))
                {
                    throw new ArgumentException("La cadena ingresada no es un entero!");
                }
            }
        }

        public static void LanzarSiEsCadenaVaciaONula(this string cadena)
        {
            if(string.IsNullOrEmpty(cadena) || string.IsNullOrWhiteSpace(cadena))
            {
                throw new ArgumentException("Ingrese algun valor!");
            }
        }
    }
}
