using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 46576483;
            string newx=Convert.ToString(x);
           
            foreach(var i in newx)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                
            }

        }
    }
}
