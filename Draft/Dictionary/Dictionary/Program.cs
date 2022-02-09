using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = "You can gain experience, if you are careful to avoid empty redundancy. Do not fall into the error of the artisan who boasts of twenty years experience in craft while in fact he has had only one year of experience-twenty times. And never resent the advantage of experience your elders have. Recall that they have paid for this experience in the coin of life, and have emptied a purse that cannot be refilled.";

            string[] spearator = { " ", ".", ", ", "-", };

            int count = 80;

            string[] strlist = text.Split(spearator, count,
               StringSplitOptions.RemoveEmptyEntries);







            RandomWord(strlist);




        }




        public static void RandomWord(string[] sozler)
        {
            int score = 0;
            var idx = new Random().Next(sozler.Length);
            Console.WriteLine(sozler[idx]);
            Console.WriteLine("Please insert the wordd you think will be the next");
            string input = Console.ReadLine();

            if (input == sozler[idx + 1])
            {
                Console.WriteLine("you got a 6 coins");
                score += 6;
            }
            else
            {
                Console.WriteLine("You were wrong, and you lost to get 6 coins try once more");
                string input2 = Console.ReadLine();
                if (input2 == sozler[idx + 1])
                {
                    Console.WriteLine("You got a 4 coins");
                    score += 4;
                }
                else
                {
                    Console.WriteLine("You were wrong, and you lost to get 4 coins, try once more");
                    string input3 = Console.ReadLine();
                    if (input3 == sozler[idx + 1])
                    {
                        Console.WriteLine("you got a 3 coins");
                        score += 3;
                    }
                    else
                    {
                        Console.WriteLine("That is enough let play another game");
                    }
                }
            }
        }




    }

}












