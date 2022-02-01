using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            DetermineAge(age);
            
        }

        public static void DetermineAge(int age)
        {   
            
                if (age > 0 && age < 30)
                {
                    int kv = age * age;
                    Console.WriteLine(kv);
                }

                else if (age > 30 && age < 40)
                {
                    char[] newage = age.ToString().ToArray();
                    Console.WriteLine(newage[1]);

                }
                else if (age > 100)
                {
                    Console.WriteLine("Neyise sef yazmisan qadanalim");
                }
                else if (age < 0)
                {
                Console.WriteLine("Neyise sef yazmisan qadanalim");
                }
            
            
        }
    }
}
//s ualim: niye sonuncu olan 2 else if men bir else ifde yaza bilmedim?
