﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    internal interface IPerson
    {
        public string Name { get; }
        public byte Age { get; }
        public Services Service { get; }
    }
}
