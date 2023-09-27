using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeapYear(2004); 
            Console.Read();
        }

        static double AbsoluteValue(double a)
        {
            Console.WriteLine(Math.Abs(a));
            return Math.Abs(a);
        }

        static int ToNumber(int a, int b)
        {
            if (a % 2 == 0 || a % 3 == 0 && b % 2 == 0 || b % 3 == 0)
            {
                int c = a * b;
                Console.WriteLine(c);
                return c;
            } else
            {
                int c = a + b;
                Console.WriteLine(c);
                return c;
            }
        }

        static bool ChecklUpper(string s)
        {
            return (s == s.ToUpper());

        }

        static bool IfGreaterThanThirdOne(int a, int b, int c)
        {
            return (a + b > c || a * b > c);
        }

        static bool IfNumberIsEven(int a)
        {
            return (a % 2 == 0);
        }

        static bool IfSortedAcsvending(int[] a)
        {
            int[] b = a;
            Array.Sort(b);
            return b == a;
        }

        static string PositiveNegativeOrZero(int a)
        {
            if (a > 0) {
                Console.WriteLine("Positive");
                return "Positive"; 
            } else if (a < 0) {
                Console.WriteLine("Negative");
                return "Negative";
            } else {
                Console.WriteLine("0");
                return "0";
            }
        }

        static bool LeapYear(int a)
        {
            Console.WriteLine(DateTime.IsLeapYear(a));
            return DateTime.IsLeapYear(a);
        }
    }
}
