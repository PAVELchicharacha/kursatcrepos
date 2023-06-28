using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    internal class Visitor : IPerson
    {
        public string Name { get; }
        public byte Age { get; }
        public Aboniment Aboniment { get; }
        public string SecondName { get; }

        public Visitor(string Name, byte Age, Aboniment Aboniment)
        {
            this.Name = Name;
            this.Age = Age;
            this.Aboniment = Aboniment;
        }
    }
}
