using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    internal class ClubVisitor : Person
    {
        public ClubServices Service { get; }

        public ClubVisitor(string name, string secondName, byte age, Sex sex, ClubServices services)
            : base(name, secondName, age, sex)
        {
            Service = services;
        }
    }
}
