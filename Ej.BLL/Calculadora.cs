using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.BLL
{
    public class Calculadora
    {
        public int Dividir(int dividendo, int divisor)
        {
            if(divisor == 0)
            {
                throw new DivideByZeroException();
            }
            return dividendo / divisor;
        }
    }
}
