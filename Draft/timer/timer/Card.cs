using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timer
{
    class VirtualCard
    {
        private long _cardnumber;
        public int cash;
        DateTime time;
        static List<VirtualCard> kaartxana = new List<VirtualCard>();

        public long cardnumber
        {
            get { return _cardnumber; }
            set
            {
                Random rd = new Random();
                string num = "";
                for (int i = 0; i < 16; i++)
                {

                    int rand_num = rd.Next(0, 9);

                    num = num + rand_num;
                }

                value = long.Parse(num);
                _cardnumber = value;


            }
        }

        public VirtualCard(int money, int restdays)
        {
            if (money > RealCard.Accountmoney)
            {
                Console.WriteLine("You aaaaaaaaaaaaa dont have enough money on your main acc, try again");
                money = Convert.ToInt32(Console.ReadLine());

            }

            cash = money;
            RealCard.Accountmoney = RealCard.Accountmoney - money;

            DateTime time2=DateTime.Now;
            time = time2.AddDays(restdays);
        }
        public static void AddCardtoList(VirtualCard kartt)
        {
            if(kaartxana.Count < 5)
            {
                kaartxana.Add(kartt);
              
            }
            else
            {
                Console.WriteLine("you havee reached max number of cards");
            }
            
        }

        public static void ShowAllCards()
        {
            if (kaartxana.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine( "You did not creat any cards yet" );
            }
            else
            {
                foreach (var jjj in kaartxana)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Your virtual cards " + jjj.cardnumber + " with " + jjj.cash + " azn and it will be allow to use for " + jjj.time);
                }
            }
            
            
        }
        public static void RemoveCardFromList (/*VirtualCard kartt*/)
        {
            if (kaartxana.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have not created aa virtual card, in order to delete it");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("type a card code you wand to delete");
                long input=Convert.ToInt64(Console.ReadLine());
                for(int i=0; i<kaartxana.Count; i++)
                {
                    if (kaartxana[i].cardnumber == input)
                    {
                        RealCard.Accountmoney=RealCard.Accountmoney + kaartxana[i].cash;
                        kaartxana.RemoveAt(i);
                        Console.ForegroundColor=ConsoleColor.Yellow;
                        Console.WriteLine("Now money on your main card increased and became: " + RealCard.Accountmoney);

                    }
                }
            }
        }

    }

    static class RealCard
    {
        public static int Accountmoney;

    }
}
