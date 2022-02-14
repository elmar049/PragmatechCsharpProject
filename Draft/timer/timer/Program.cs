using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace timer
{
    internal class Program
    {


        static void Main(string[] args)
        {


            //Console.WriteLine("Insert the number money on your main card");
            //int esaskartpul = Convert.ToInt32(Console.ReadLine());
            //RealCard.Accountmoney = esaskartpul;





            //Console.WriteLine("if you want to creat a card please press 1");
            //string pressOne = Console.ReadLine();
            //if (pressOne == "1")
            //{              
            //    Console.WriteLine("How much money you want to have on it");
            //    int denqinakartu = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("For how long this card will be active? Write the number of days from today date");
            //    int koldney= Convert.ToInt32(Console.ReadLine());
            //    if (denqinakartu < RealCard.Accountmoney)
            //    {
            //        VirtualCard card1 = new VirtualCard(denqinakartu, koldney);

            //    }

            //}

            List<string> list = new List<string>();
            string ff = "ssalam";
            string ff2 = "fff";
            string ff3 = "ffffffff";



            list.Add(ff);
            list.Add(ff2);
            list.Add(ff3);

            list.RemoveAt(2);




            foreach (var fff in list)
            {
                Console.WriteLine( fff );
            }






        }


    }


}
