using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class CashRegister
    {
        public double TotalAmount { get; set; }
        private int _totalSaleCount { get; set; }
        public Currency type;
        public List<double> kassa = new List<double>();


        public int TotalSaleCount
        {
            get
            {
                return this._totalSaleCount;
            }
            set
            {
                _totalSaleCount = 0;
            }
        }


        public CashRegister(Currency tipi, double obwisumma)
        {
            type = tipi;
            TotalAmount = obwisumma;
        }


        public void AddSale(Currency tppii, double money)
        {
            double obwqakovu = 0;
            double sum = 0;
            if (tppii != type)
            {
                if (tppii == Currency.USD)
                {
                    //if (Currency.USD == tppii)

                    ++TotalSaleCount;
                    kassa.Add(money);

                    for (int i = 0; i < kassa.Count; i++)
                    {
                        obwqakovu = obwqakovu + kassa[i];
                    }
                    sum = TotalAmount + obwqakovu * 1.7;


                    Console.WriteLine($"You added {money} {Currency.USD} in a cashRegister and now your money encreased to {sum}, and total Sale Count is {TotalSaleCount}");
                }
                //if (tppii == Currency.EU)
                //{

                //    ++TotalSaleCount;
                //    kassa.Add(money);

                //    for (int i = 0; i < kassa.Count; i++)
                //    {
                //        sum = sum + kassa[kassa.Count-1]*1.9;
                //    }



                //    Console.WriteLine($"You added {money} {Currency.EU} in a cashRegister and now your money encreased to {sum}, and total Sale Count is {TotalSaleCount}");
                //}
                if (tppii == Currency.tl)
                {
                    double y = 0;

                    ++TotalSaleCount;
                    kassa.Add(money);
                    for (int i = 0; i < kassa.Count; i++)
                    {
                        y = y + kassa[kassa.Count - 1] * 0.2;
                    }
                    sum = sum + y; 

                    Console.WriteLine($"You added {money} {Currency.tl} in a cashRegister and now your money encreased to {sum}, and total Sale Count is {TotalSaleCount}");
                }

            }
            else
            {
                TotalAmount = TotalAmount + money;
                ++TotalSaleCount;

                Console.WriteLine($"You added {money} in a cashRegister and now your money encreased to {TotalAmount}, and total Sale Count is {TotalSaleCount}");
            }
        }

        public void RemoveSale(Currency tppp, double moneyy)
        {

        }

    }

    public enum Currency
    {
        USD = 1,
        EU = 2,
        AZN = 3,
        tl = 4,

    }

    public enum PaymentType
    {
        Card,
        Cash
    }
}
