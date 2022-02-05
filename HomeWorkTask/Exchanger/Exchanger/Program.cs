using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchanger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please Choose the currency you want to exchange: \n1. USD \n2. EU \n3. Aze \n4. Tl");

                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Now please write the amount of money");
                double input = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("PLease insert the curreny you wanto to excahnge:  \n1. USD \n2. EU \n3. Aze \n4. Tl");
                int y = Convert.ToInt32(Console.ReadLine());



                if (x == 1 && y == 1)
                {
                    double res = input;
                    Console.WriteLine($"You money will make {res} USD");
                }
                if (x == 1 && y == 2)
                {
                    double res = input * 0.9;
                    Console.WriteLine($"You money will make {res} euros");
                }
                if (x == 1 && y == 3)
                {
                    double res = input * 1.7;
                    Console.WriteLine($"You money will make {res} azn");
                }
                if (x == 1 && y == 4)
                {
                    double res = input * 15;
                    Console.WriteLine($"You money will make {res} lira");
                }



                if (x == 2 && y == 1)
                {
                    double res = input / 0.9;
                    Console.WriteLine($"You money will make {res} usd");
                }
                if (x == 2 && y == 2)
                {
                    double res = input;
                    Console.WriteLine($"You money will make {res} euros");
                }
                if (x == 2 && y == 3)
                {
                    double res = input * 1.9;
                    Console.WriteLine($"You money will make {res} azn");
                }
                if (x == 2 && y == 4)
                {
                    double res = input * 17;
                    Console.WriteLine($"You money will make {res} liras");
                }



                if (x == 3 && y == 1)
                {
                    double res = input / 1.7;
                    Console.WriteLine($"You money will make {res} usd");
                }
                if (x == 3 && y == 2)
                {
                    double res = input / 1.9;
                    Console.WriteLine($"You money will make {res} euros");
                }
                if (x == 3 && y == 3)
                {
                    double res = input;
                    Console.WriteLine($"You money will make {res} azn");
                }
                if (x == 3 && y == 4)
                {
                    double res = input * 9;
                    Console.WriteLine($"You money will make {res} liras");
                }




                if (x == 4 && y == 1)
                {
                    double res = input / 15;
                    Console.WriteLine($"You money will make {res} usd");
                }
                if (x == 4 && y == 2)
                {
                    double res = input / 17;
                    Console.WriteLine($"You money will make {res} euros");
                }
                if (x == 4 && y == 3)
                {
                    double res = input / 9;
                    Console.WriteLine($"You money will make {res} azn");
                }
                if (x == 4 && y == 4)
                {
                    double res = input;
                    Console.WriteLine($"You money will make {res} lira");
                }

            }



        }
    }





    
}

