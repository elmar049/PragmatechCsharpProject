using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the word and you will the number of letters: ");

            string soz = Console.ReadLine();
            Console.WriteLine(TheNumberOfLetters(soz));


        }

        public static int TheNumberOfLetters(string input)
        {
            int x = input.Length;
            return x;

        }
    }
}

