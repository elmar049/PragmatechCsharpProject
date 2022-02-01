using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] array1 = { 23, 65, 1, 54, 5 };


            Array.Sort(array1);
            Console.WriteLine(array1[0]);   // It is to find the lowest value
            Array.Reverse(array1);
            Console.WriteLine(array1[0]);    // it is to find the highest value


            //int biggest = 0;

            //foreach(int i in array1)
            //{
            //    if (i > biggest)
            //    {
            //        biggest=i;

            //    }
            //    Console.WriteLine(biggest);
        }
    }
    }

