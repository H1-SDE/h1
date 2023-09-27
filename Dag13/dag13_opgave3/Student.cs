using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dag13_opgave3
{
    internal class Student
    {
        private static Person person = new Person();
        public void Study()
        {
            Console.WriteLine("I'm studying");
            return;
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is: " + person.Age + " years old");
            return;
        }
    }
}
