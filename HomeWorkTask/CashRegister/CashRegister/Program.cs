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
                Console.WriteLine("IF you want to add money press 1, if you want to take money please press 2:");

                string rrr = Console.ReadLine();

                if(rrr == "1")
                {
                    Console.WriteLine("Choose the currency of the CashRegister: \n1.AZN \n2.USD \n3.EU ");
                    string kassacurrecny = Console.ReadLine();

                    Console.WriteLine("Select the currency you have:  \n1.AZN \n2.USD \n3.EU");
                    string cibdekipul = Console.ReadLine();


                    Console.WriteLine("How much do you have?");
                    int userpulu = Convert.ToInt32(Console.ReadLine());


                    CashRegister app1 = new CashRegister(100);
                    app1.type = (Currency)(Enum.Parse(typeof(Currency), kassacurrecny));

                    app1.AddSale(cibdekipul, userpulu, kassacurrecny);
                }
                if(rrr == "2")
                {
                    Console.WriteLine("Choose the currency of the CashRegister: \n1.AZN \n2.USD \n3.EU ");
                    string kassacurrecny = Console.ReadLine();

                    Console.WriteLine("Select the currency you have:  \n1.AZN \n2.USD \n3.EU");
                    string cibdekipul = Console.ReadLine();


                    Console.WriteLine("How much do you have?");
                    int userpulu = Convert.ToInt32(Console.ReadLine());


                    CashRegister app1 = new CashRegister(100);
                    app1.type = (Currency)(Enum.Parse(typeof(Currency), kassacurrecny));
                    app1.removeSale(cibdekipul, userpulu, kassacurrecny);
                }
                else
                {
                    break;
                }
               
                

                


            }











        }
    }
}
