using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the action number");
            Console.WriteLine("1. + (plus)");
            Console.WriteLine("2. - (minus)");
            Console.WriteLine("3. * (multiple)"); 
            Console.WriteLine("4. / (division)"); 
            int action=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type first digit");
            int frst=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type second digit");
            int scnd = Convert.ToInt32(Console.ReadLine());

            int results = 0;

            switch (action)
            {
                case 1: {
                        results = Addition(frst, scnd);
                        break;
                    }

                case 2:
                    {
                        results = Extraction(frst, scnd);
                        break;
                    }

                case 3:
                    {
                        results = Multiplication(frst, scnd);
                        break;
                    }
                case 4:
                    {
                        results = Division(frst, scnd);
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Wrong action");
                        break;
                    }

            }


            Console.WriteLine($"result: {results}");

        }

        public static int Addition( int x, int y)
        {
            int result = x + y;
            return result;
                
        }

        public static int Extraction(int x, int y)
        {
            int result = x - y;
            return result;
        }

        public static int Multiplication(int x, int y)
        {
            int result = x * y;
            return result;

        }
        public static int Division(int x, int y)
        {
            int result = x / y;
            return result;

        }



    }  
        
        
}
