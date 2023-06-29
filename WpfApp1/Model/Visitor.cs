using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    internal class Visitor : Person
    {
        public Services Service { get; }

        public Visitor(string name, string secondName, byte age, Sex sex, Services services)
            : base(name, secondName, age, sex)
        {
            Service = services;
        }
    }
}
