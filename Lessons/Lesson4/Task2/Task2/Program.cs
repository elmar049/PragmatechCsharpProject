using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MultiplyTheNumbers(3581));
        }

        public static int MultiplyTheNumbers(int x)
        {
            int [] newX=x.ToString().Select(o=>Convert.ToInt32(o)-48).ToArray();     
            int sum=0;

            foreach (var i in newX)
            {
                sum = sum + i;
                
            }
            return sum;
        }

    }
}
