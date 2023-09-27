using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace dag13_opgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personer = new List<Person>();

            for (int i = 0; i < 3; i++)
            {
                string line = Console.ReadLine();
                Person p = new Person(line);
                personer.Add(p);
            }

            foreach (Person i in personer)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
