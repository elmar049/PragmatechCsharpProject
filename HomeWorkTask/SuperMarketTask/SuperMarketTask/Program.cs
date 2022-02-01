using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SuperMarketTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] endirimliMallar = new string[5];
            //endirimliMallar[0] = "Kartof";
            //endirimliMallar[1] = "Corek";
            //endirimliMallar[2] = "Alma";
            //endirimliMallar[3] = "Duz";
            //endirimliMallar[4] = "Makaron";




            //item[] cart = new item[1];

            ////double saleprice = 0;
            //double totalprice = 0;
            //double totalpriceall = 0;
            //;

            //for (int i = 0; i < cart.Length; i++)
            //{
            //    Console.WriteLine("Malin Adi: ");
            //    string malinadi = Console.ReadLine();

            //    Console.WriteLine("Malin qiymet: ");
            //    double malinqiymet = Convert.ToDouble(Console.ReadLine());

            //    foreach (var item in endirimliMallar)
            //    {
            //        if (malinadi == item)
            //        {
            //            malinqiymet = malinqiymet / 2;
            //        }



            //    }

            //    Console.WriteLine("Malin sayini ve ya kq-ile sayini bildirin: ");
            //    int malinsayi = Convert.ToInt32(Console.ReadLine());

            //    item malobyekti = new item(malinadi, malinqiymet, malinsayi);
            //    cart[i] = malobyekti;



            //    Console.WriteLine("That is all? (Yes/No)");
            //    string reply = Console.ReadLine();
            //    if (reply == "No")
            //    {
            //        Array.Resize(ref cart, cart.Length + 1);
            //    }
            //    else if (reply == "Yes")
            //    {
            //        for (int j = 0; j < cart.Length; j++)
            //        {
            //            totalprice = cart[j].Number * cart[j].Price;
            //            totalpriceall = totalpriceall + totalprice;
            //        }

            //        Console.WriteLine("Lets calculate your all price, which will be: " + totalpriceall);

            //        Console.WriteLine("Customer's payment: ");
            //        double odenish = Convert.ToDouble(Console.ReadLine());

            //        if (odenish < totalpriceall)
            //        {
            //            double rest = totalpriceall - odenish;
            //            Console.WriteLine("You have not provide enough money, you must give " + rest + " more.");

            //            Console.WriteLine("Customer's rest payment: ");
            //            double secondodenish = Convert.ToDouble(Console.ReadLine());

            //            if (secondodenish == rest)
            //            {
            //                Console.WriteLine("Ay kasib bunu evvelceden verde, saya bilmirsen?");
            //            }


            //        }
            //        else if (odenish >= totalpriceall)
            //        {
            //            double oddmoney = odenish - totalpriceall;

            //            Console.WriteLine("thank you for you purchases, that is you odd money: " + oddmoney);
            //            Console.WriteLine(DateTime.Now);
            //        }

            //    }



            //}



            Dictionary<int, string> map = new Dictionary<int, string>();
            map.Add(0, "elmaer");
            map.Add(1, "hhh");
            map.Add(5, "kkkk");


            foreach (KeyValuePair<int,string> key in map)
            {
                Console.WriteLine(key.Key + " " + key.Value);
            }

            map[5] = "jjjjjjj";

            foreach (KeyValuePair<int, string> key in map)
            {
                Console.WriteLine(key.Key + " " + key.Value);
            }

            Console.WriteLine(map[5]);






        }










    }
}



