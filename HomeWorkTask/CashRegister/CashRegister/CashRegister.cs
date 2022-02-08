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
        public Dictionary<Currency, double> kassa = new Dictionary<Currency, double>();


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


        public CashRegister(double obwisumma)
        {
            type = Currency.AZN;
            TotalAmount = obwisumma;
        }


        public void AddSale(string kassakurrr, double money, string evvelki)
        {
            double cem = 0;
            if ((Currency)Enum.Parse(typeof(Currency), kassakurrr) == ((Currency)Enum.Parse(typeof(Currency), evvelki)))
            {
                TotalAmount = TotalAmount + money;
                Console.WriteLine($"You added {money} in a cashRegister and now your money encreased to {TotalAmount}");


            }
            else
            {
                if((Currency)Enum.Parse(typeof(Currency), evvelki)==Currency.USD  &&  (Currency)Enum.Parse(typeof(Currency), kassakurrr)== Currency.EU)
                {
                    cem = money * 1.12;
                    TotalAmount=TotalAmount + cem;
                    Console.WriteLine($"You added {money} EU, which make {cem} usd, in a cashRegister and now your money encreased to {TotalAmount}");
                }
                else if((Currency)Enum.Parse(typeof(Currency), evvelki) == Currency.USD && (Currency)Enum.Parse(typeof(Currency), kassakurrr) == Currency.AZN)
                {
                    cem = money * 0.58;
                    TotalAmount = TotalAmount + cem;
                    Console.WriteLine($"You added {money} azn, which make {cem} usd, in a cashRegister and now your money encreased to {TotalAmount}");
                }

                else if((Currency)Enum.Parse(typeof(Currency), evvelki) == Currency.EU && (Currency)Enum.Parse(typeof(Currency), kassakurrr) == Currency.AZN)
                {
                    cem = money / 2;
                    TotalAmount = TotalAmount + cem;
                    Console.WriteLine($"You added {money} azn, which make {cem} eu, in a cashRegister and now your money encreased to {TotalAmount}");
                }
                else if ((Currency)Enum.Parse(typeof(Currency), evvelki) == Currency.EU && (Currency)Enum.Parse(typeof(Currency), kassakurrr) == Currency.USD)
                {
                    cem = money / 1.12;
                    TotalAmount = TotalAmount + cem;
                    Console.WriteLine($"You added {money} usd, which make {cem} eu, in a cashRegister and now your money encreased to {TotalAmount}");
                }
                else if((Currency)Enum.Parse(typeof(Currency), evvelki) == Currency.AZN && (Currency)Enum.Parse(typeof(Currency), kassakurrr) == Currency.USD)
                {
                    cem = money * 1.7;
                    TotalAmount = TotalAmount + cem;
                    Console.WriteLine($"You added {money} usd, which make {cem} azn, in a cashRegister and now your money encreased to {TotalAmount}");
                }
                else if ((Currency)Enum.Parse(typeof(Currency), evvelki) == Currency.AZN && (Currency)Enum.Parse(typeof(Currency), kassakurrr) == Currency.EU)
                {
                    cem = money * 2;
                    TotalAmount = TotalAmount + cem;
                    Console.WriteLine($"You added {money} eu, which make {cem} azn, in a cashRegister and now your money encreased to {TotalAmount}");

                }

            }
           
            
        }




    }





    public enum Currency
    {
        AZN = 1,
        USD = 2,
        EU = 3,
        

    }


}
