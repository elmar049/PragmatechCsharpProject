using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Insert the number you want to change: ");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + " First meaning");
            
            Console.WriteLine(x + " Changed meaning");
            Console.WriteLine(ChangeNumber(x));








        }
        
        public static int ChangeNumber(int input)
        {
            int sum = 0;
            int res = 0;
            for (int i=1; i<9; i++)
            {
                sum = input * i;
                res = res + sum;
            }
            
            return res;

        }
       


    }   

        
}
