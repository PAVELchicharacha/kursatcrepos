using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    enum Sex
    {
        Male,Female
    }
    internal abstract class Person
    {
        public string Name { get; }
        public string SecondName { get; }
        public byte Age { get; }
        public Sex Sex { get; }

        public Person(string name, string secondName, byte age, Sex sex)
        {
            Name = name;
            SecondName = secondName;
            Age = age;
            Sex = sex;
        }
    }
}
