using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dag13_opgave3
{
    internal class StudentProfessorTest
    {
        Person person = new Person();
        Student student = new Student();
        Professor teacher = new Professor();



        public void main()
        {
            newPerson("hallo");
            newStudent("hallo", 15);
            newTeacher("hallo", 30);
            Console.ReadLine();
        }

        public void newPerson(string greet)
        {
            person.Greet = greet;
            Console.WriteLine(greet);
            return;
        }

        public void newStudent(string greet, int age)
        {
            person.Greet = greet;
            person.Age = age;
            Console.WriteLine(person.Greet);

            student.ShowAge();
            return;
        }

        public void newTeacher(string greet, int age)
        {
            person.Greet = greet;
            person.Age = age;
            Console.WriteLine(person.Greet);
            teacher.Explain();
            return;
        }

    }
}
