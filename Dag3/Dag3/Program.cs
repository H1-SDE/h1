using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag3
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            for(int j = 1; j <=10 ; j = j + 1) {
            
            
            String text = "";
            
            Console.ReadLine();
        }

        static string Stars(string stars)
        {
            string stars = "         *";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(stars);
                stars = stars.Remove(0, 1);
                stars += "**";
                return stars;
            }
        }

        static string multiTabel (string test)
        {
            for (int j = 1; j <= 10; j = j + 1)
            {


                String text = "";

                for (int i = 1; i <= 10; i = i + 1)
                {
                    text = text + i * j + " ";





            } 
            Console.WriteLine(text);

            }
=======
            //Console.WriteLine(theBiggestNumber(new int[] { 12, 23, 193, 1312 }));
            //Console.WriteLine(threeIncreasingAdjacent(new int[] { 1, 4, 1, 1, 4, 3, 4, 5, 6, 7, 5, 4, 9 }));
            Console.WriteLine(extractString("##abc##def"));  // 123456789
            Console.ReadLine();
        }
        
        public static int[] SieveOfEratosthenes(int a)
        {
            int[] res = { };
            var tempRes = res.ToList();

            for (int i = 0; i < a; i++)
            {
                if (!(i % 2 == 0 || i % 3 == 0 || i == 1 ) || i == 2 || i == 3) {
                    tempRes.Add(i);
                }
            }

            res = tempRes.ToArray();
        return res;

        }

        public static double ToThePowerOf(int a, int b)
        {
            double c = a;

            for (int i = 1; i < b; i++)
            {
                c *= Convert.ToDouble(a);
            }

            return c;
        }

        public static string SumAndAverage(int a, int b)
        {
            if (!(a <= b)) { (a, b) = (b, a); }

            int[] arr = { };
            var arr2 = arr.ToList();

            for (int i = a; i < b+1; i++)
            {
                arr2.Add(i);
            }

            int sum = arr2.Sum();
            double avg = arr2.Average();

            return "Sum: " + Convert.ToString(sum) + ", Average: " + Convert.ToString(avg);
        }

        public static string FullSequenceOfLetters(char a, char b)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            

            string[] res = { };
            var res2 = res.ToList();

            int add = 0;

            foreach (char e in alphabet)
            {
                if (e == a || e == b) {
                    add += 1; 
                    if (add == 2) {
                        res2.Add(Convert.ToString(e)); 
                    }
                }
                if (add == 1) { res2.Add(Convert.ToString(e)); }
            }

            return String.Join(" ", res2);
            //Console.WriteLine(theBiggestNumber(new int[] { 12, 23, 193, 1312 }));
            //Console.WriteLine(threeIncreasingAdjacent(new int[] { 1, 4, 1, 1, 4, 3, 4, 5, 6, 7, 5, 4, 9 }));
            Console.WriteLine(extractString("##abc##def"));  // 123456789
            Console.ReadLine();
        }
        
        //Two 7s next to each other
        static int two7sNextToEachOther(int[] numberOfTimes)
        {
            int int2 = 0;
            for (int i = 0; i < numberOfTimes.Length - 1; i++)
            {
                if (numberOfTimes[i] == 7 && numberOfTimes[i + 1] == 7)
                {
                    int2++;
                }
            }
            return int2;
        }

        //The biggest number
        static int theBiggestNumber(int[] number)
        {
            return number.Max();
        }

        //Three increasing adjacent
        static bool threeIncreasingAdjacent(int[] numbers)
        {
            for (int i = 0; i <= numbers.Length - 3; i++)
            {
                if (numbers[i] == numbers[i + 1] - 1 && numbers[i] == numbers[i + 2] - 2)
                {
                    return true;
                }
            }
            return false;
        }

        static string extractString(string word)
        {
            int firstWord = word.IndexOf("##") + 2;
            int secondWord = word.IndexOf("##", firstWord);
            if (secondWord - firstWord == 0 || secondWord == -1)
            {
                return "empty string";
            }
            return word.Substring(firstWord, secondWord - 2);
>>>>>>> main
                }
                Console.WriteLine(text);
            }
            return test;
        }
    }
}
  
    