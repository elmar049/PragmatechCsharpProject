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
            while (true)
            {
                Console.WriteLine("Choose the currency of the CashRegister: \n1.AZN \n2.USD \n3.EU \n4.RUB ");
                string kassacurrecny = Console.ReadLine();

                Console.WriteLine("Select the currency you have:  \n1.AZN \n2.USD \n3.EU \n4.RUB");
                string cibdekipul = Console.ReadLine();


                Console.WriteLine("How much do you have?");
                int userpulu = Convert.ToInt32(Console.ReadLine());





                CashRegister app1 = new CashRegister(100);
                app1.type = (Currency)(Enum.Parse(typeof(Currency), kassacurrecny));

                app1.AddSale(cibdekipul, userpulu, kassacurrecny);

                


            }











        }
    }
}
