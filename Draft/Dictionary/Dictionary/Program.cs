using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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





            Console.WriteLine("Welcome to the game of Elmar. You will get a word, your goal is determine what is gonna be the second one. \nFirst attempt will give 6 points \nSecond attempt will give 4 points  \nThird attempt will give 2 points.  \nYou will have a 2 min. \nPress 1 and you will start and you time will be countdown: ");
            int one = Convert.ToInt32(Console.ReadLine());
            if (one == 1)
            {
                int num = 0;
                TimerCallback tm = new TimerCallback(Elmar.Count);
                Timer timer = new Timer(tm, num, 120000, 0);

                Elmar.RandomWord(strlist);
            }



            //Console.ReadLine();


        }

        static class Elmar
        {
            public static int score = 0;
            public static int countofexp = 0;
            public static int rightans = 0;
            public static List<string> list = new List<string>();



            public static void RandomWord(string[] sozler)
            {


                while (true)
                {
                    var idx = new Random().Next(sozler.Length);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(sozler[idx]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please insert the word you think will be the next");
                    string input = Console.ReadLine();

                    if (input == sozler[idx + 1])
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("you got a 6 coins");
                        score += 6;
                        rightans++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("You were wrong, and you lost to get 6 coins try once more");
                        string input2 = Console.ReadLine();
                        if (input2 == sozler[idx + 1])
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("You got a 4 coins");
                            score += 4;
                            rightans++;

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("You were wrong, and you lost to get 4 coins, try once more");
                            string input3 = Console.ReadLine();
                            if (input3 == sozler[idx + 1])
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("you got a 2 coins");
                                score += 2;
                                rightans++;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("That is enough let play another round");
                                string hhh = sozler[idx] + " " + sozler[idx + 1];
                                list.Add(hhh);
                            }
                        }
                    }
                    countofexp++;
                }


            }
            public static void Count(object obj)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Time is UP, lets calculate your results, be away from a keyboard. Dont Touch it");

                Console.WriteLine("YOU SCORE is: " + Elmar.score);
                Console.WriteLine("The number of all questions " + Elmar.countofexp);
                Console.WriteLine("The number of right answers: " + Elmar.rightans);
                int res = Elmar.countofexp - Elmar.rightans;
                Console.WriteLine("The number of wrong answers: " + res);
                foreach (var x in list)
                {
                    Console.WriteLine("That is right answer: " + x);
                }




            }
        }






    }

}












