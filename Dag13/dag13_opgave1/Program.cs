using System;
using System.Collections.Generic;

namespace dag13_opgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            List<Person> personer = new List<Person>();

            for (int i = 0; i < 3; i++)
            {
                person.Name = Console.ReadLine();
                personer.Add(person);
            }

            foreach (Person person_print in personer)
            {
                Console.WriteLine("Hello! My name is " + person_print.Name);
            }
            Console.ReadLine();
        }
    }
}
