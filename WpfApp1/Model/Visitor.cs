using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    internal class Visitor : Person
    {
        public Aboniment Aboniment { get; }

        public Visitor(string name, string secondName, byte age, Sex sex, Aboniment aboniment) 
            :   base(name,secondName,age,sex)
        {
            Aboniment = aboniment;
        }
    }
}
