using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write any word");
            string word = Console.ReadLine();
            Console.WriteLine(LastChar(word));


        }
        public static char LastChar(string input)
        {
            char x = Convert.ToChar(input.Substring(input.Length-1, 1));
            return x;
        }
    }
}
