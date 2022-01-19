using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMedicinee
{
    internal class Medicine
    {
        public string Name;
        public int Price;
        public int Count;



        public Medicine(string ad, int qiymet)
        {
            Name = ad;
            Price = qiymet;
            
        }

        public void Sell(string dermanAdi, int dermanSayi, Medicine[] medicines)
        {
            if (dermanAdi==Name && dermanSayi <= Count)
            {
                int qaliq = Count - dermanSayi;
                Console.WriteLine($"Bu {Name}-indan {qaliq} qeder qalib ");
            }
            else
            {
                Console.WriteLine("Depoda bu qeder derman yoxudr");
            }
                  
        }
    }
}
