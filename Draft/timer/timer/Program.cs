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


            Console.WriteLine( "Insert the number money on your main card");
            int esaskartpul=Convert.ToInt32(Console.ReadLine());
            RealCard.Accountmoney=esaskartpul;

            Console.WriteLine(RealCard.Accountmoney);


            
            Console.WriteLine( "if you want to creat a card please press 1");
            string pressOne=Console.ReadLine();
            if (pressOne == "1")
            {
                VirtualCard card1 = new VirtualCard();

                Console.WriteLine("How much money you want to have on it");
                int denqinakartu=Convert.ToInt32(Console.ReadLine()); 
                if( denqinakartu<RealCard.Accountmoney)
                card1.cash= denqinakartu;
            }
            
           
            

        }
        

    }


}
