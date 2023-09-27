using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dag13_opgave2
{
    internal class Person
    {
        public String Name { get; set; }

        public Person(string name) 
        {
            Name = name;
        }

        public override string ToString() {
            return ("Hello, my name is " + Name);
        }
    }
}
