using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag11_regner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers and operators separated by spaces(+,-,*,/,%,^): ");
            Calculate(Console.ReadLine().Split(' ').Select(x => Convert.ToString(x)).ToArray());
            Console.ReadLine();
        }

        static void Calculate(string[] line)
        {

            int tempval = 0;
            for (int i = 0; i < line.Length; i++)
            {
                int value = 1;
                if (!int.TryParse(line[i], out int output))
                {
                    switch (line[i].ToString())
                    {
                        case "+":
                            tempval = tempval == 0 ? Convert.ToInt32(line[i + value]) + Convert.ToInt32(line[i - value]) : tempval + Convert.ToInt32(line[i + value]);
                            break;
                        case "-":
                            tempval = tempval == 0 ? Convert.ToInt32(line[i + value]) - Convert.ToInt32(line[i - value]) : tempval - Convert.ToInt32(line[i + value]);
                            break;
                        case "*":
                            tempval = tempval == 0 ? Convert.ToInt32(line[i + value]) * Convert.ToInt32(line[i - value]) : tempval * Convert.ToInt32(line[i + value]);
                            break;
                        case "/":
                            tempval = tempval == 0 ? Convert.ToInt32(line[i + value]) / Convert.ToInt32(line[i - value]) : tempval / Convert.ToInt32(line[i + value]);
                            break;
                        case "%":
                            tempval = tempval == 0 ? Convert.ToInt32(line[i + value]) % Convert.ToInt32(line[i - value]) : tempval % Convert.ToInt32(line[i + value]);
                            break;
                        case "^":
                            tempval = (int)(tempval == 0 ? Math.Pow(Convert.ToInt32(line[i + value]), Convert.ToInt32(line[i - value])) : Math.Pow(tempval, Convert.ToInt32(line[i + value])));
                            break;
                        default:
                            Console.WriteLine("Failed in syntex");
                            return;
                    }
                }
            }
            Console.WriteLine("Result: " + tempval);
            return;
        }


    }
}
