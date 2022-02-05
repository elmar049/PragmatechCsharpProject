using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CashRegister app1 = new CashRegister(Currency.EU, 100);
            app1.AddSale(Currency.USD, 1000);
            app1.AddSale(Currency.USD, 1000);

            app1.AddSale(Currency.tl, 1000);
            app1.AddSale(Currency.tl, 1000);
            app1.AddSale(Currency.tl, 1000);






        }
    }
}
