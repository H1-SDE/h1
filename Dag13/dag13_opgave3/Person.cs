using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dag13_opgave3
{
    internal class Person
    {
        private string greet;
        private static int age;
        public string Greet
        {
            get { return greet; }
            set { greet = value; }
        }

        public int Age
        {
            set { age = value; }
            get { return age; }
        }

    }
}
