using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Logic.Abstractions
{
    public interface IEnumAllLogic<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
