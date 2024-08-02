﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class GamingComputer : Product
    {
        public string MotherBoard { get; set; }
        public string Processor { get; set; }
        public string DisplayCard { get; set; }
    }
}
