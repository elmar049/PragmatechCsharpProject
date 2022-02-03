using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackHeap
{
    internal class Program
    {
        static void Main(string[] args)
        {

             Car auto= new Car("qirmizi", "NolYeddi", 200000, 60, 40, 0.2);
            auto.Drive(10);
            auto.ShowAllInfo();


        }
    }
}
