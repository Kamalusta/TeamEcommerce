﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Smart_Home_Electronics
{
    public class Headphones : Product
    {
        public bool IsWireless { get; set; }
        public int BatteryLife { get; set; } //Nece saat saxlayir.
    }
}
