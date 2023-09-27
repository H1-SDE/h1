using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("intast antal terninger:");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                {
                    DiceOnSameTime(value);
                }
                else
                {
                    Console.WriteLine("You need to input a number");
                }
            }
            Console.ReadLine();
        }

        static void Dice(int value)
        {
            Random rnd = new Random();
            int i = 0;
            int slag = 0;
            while (i != value)
            {
                int dice = rnd.Next(1, 7);
                if (dice == 6)
                {
                    Console.WriteLine("dice" + i + ": " + dice);
                    Console.WriteLine("Antal slag: " + slag + " dice number " + i);
                    i++;
                    dice = 0;
                    slag = 0;
                }
                else
                {
                    slag++;
                }
            }
            return;
        }

        static void DiceOnSameTime(int value)
        {
            Random rnd = new Random();
            int correctdice = 0;
            int slag = 1;
            List<int> dice = new List<int>();

            while (true)
            {
                for (int i = 0; i < value; i++)
                {
                    int dice1 = rnd.Next(1, 7);
                    if (dice1 != 6)
                    {
                        slag++;
                        break;
                    }    
                    else
                    {
                        slag++;
                        dice.Add(dice1);

                    }

                }

                foreach (int i in dice)
                {
                    if (i == 6) correctdice++;
                }

                if (correctdice == value) break;
            }
            Console.WriteLine("antal slag: " + slag);
            return;
        }
    }
}
