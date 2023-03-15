﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Logic.Abstractions
{
    interface IABMLogic<T> where T : class
    {
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
    }
}
