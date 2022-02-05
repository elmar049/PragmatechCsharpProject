using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Please Choose the currency you want to exchange: \n1. USD \n2. EU \n3. Tl ");

                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Now please write the amount of money");
                double input = Convert.ToDouble(Console.ReadLine());

                if (x == 1)
                {
                    CurrencyExchanger.Exchange(CurrencyType.USD, input);

                }
                if (x == 2)
                {
                    CurrencyExchanger.Exchange(CurrencyType.Eu, input);

                }
                if (x == 3)
                {
                    CurrencyExchanger.Exchange(CurrencyType.TL, input);

                }
            }
           

        }
    }



    static class CurrencyExchanger
    {

      
        public static Dictionary<CurrencyType, double> currency = new Dictionary<CurrencyType, double>();
        

        public static void Exchange(CurrencyType tayp, double pul)
        {
            
            currency.Add(tayp, pul);
            double x = 0;
            if (tayp == CurrencyType.Eu)
            {
                x = pul * 2;
            }
            else if (tayp == CurrencyType.USD)
            {
                x = pul * 1.7;
            }
            else if (tayp == CurrencyType.TL)
            {
                x = pul * 0.19;
            }

            Console.WriteLine($"Sizin daxil elediyniz {pul} {tayp}-iniz, indiki kursla {x} azn eleyir");
        }


    }


    public enum CurrencyType
    {
        USD=1,
        Eu=2,
        TL=3,
        AZE=4,
    }
}

