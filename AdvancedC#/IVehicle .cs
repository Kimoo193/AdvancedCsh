﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Csh
{
    public interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }
}
