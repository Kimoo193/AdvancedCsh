﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Csh
{
    public interface IStack<T>
    {
        void Push(T item);
        T Pop();
    }

}
