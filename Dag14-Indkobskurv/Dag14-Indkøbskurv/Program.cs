using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dag14_Indkøbskurv
{
    internal class Program
    {
        static public bool startCheck = false;
        static public Data data = new Data();

        static public Stopwatch watch = Stopwatch.StartNew();
        static void Main(string[] args)
        {

            while (true)
            {
                start();
            }
        }

        static void start()
        {
            if (!startCheck)
            {
                Console.WriteLine("\nWhat are you?");
                Console.WriteLine("1. admin");
                Console.WriteLine("2. Normal user");
                while (true)
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            StartAdmin();
                            startCheck = false;
                            break;
                        case "2":
                            StartNormal();
                            startCheck = false;
                            break;
                        default:
                            Console.WriteLine("try agen");
                            break;
                    }
                }
            }
        }

        static void StartAdmin()
        {
            string passwd = "1234";
            Console.WriteLine("Hallo Noob plsss inter your password");
            Console.WriteLine("Password:");
            if(Console.ReadLine() == passwd)
            {
                Console.WriteLine("Hallo Admin");
                Console.WriteLine("Sorry for calling you noob");
                Console.WriteLine("Select what you want");
                Console.WriteLine("1: Edit user");
                Console.WriteLine("2: Edit Product");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("comming soon");
                        break;
                    case "2":
                        Console.WriteLine("comming soon");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Try agen later noob");
                Thread.Sleep(5000);
                StartNormal();
                return;
            }

        }

        static void StartNormal()
        {
            try
            {
                Print();

                Console.WriteLine("Kunde id: ");
                int kundeId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Produkt id: ");
                int produktId = Convert.ToInt32(Console.ReadLine());

                data.GetCustomers()[kundeId].AddToCart(kundeId, data.GetProducts()[produktId]);
            }
            catch { Console.WriteLine("Fejl. Tryk en tast for at fortsætte"); Console.ReadLine(); };
        }

        static void Print()
        {
            Console.Clear();
            foreach (Product i in data.GetProducts())
            {
                Console.Write("id: " + i.Id + "\tTitle: " + i.Title + "\t Type: " + i.Type);
                if (i.Type == "ticket")
                {
                    Console.Write("\t\tTid: " + i.watch.ElapsedMilliseconds + "\n");
                }
                else { Console.WriteLine(""); };
            }

            Console.WriteLine("");

            foreach (Customer i in data.GetCustomers())
            {
                Console.WriteLine("id: " + i.Id + "\tName: " + i.Name);
                
                i.Cart.ForEach(x => Console.WriteLine("\t\t- " + x.Title));
            }

            Console.WriteLine("");
        }
    }
}
