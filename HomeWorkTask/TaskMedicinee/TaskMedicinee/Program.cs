using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMedicinee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medicine pillOne = new Medicine("Noshpa", 1);
            pillOne.Count = 100;
            

            Medicine pillTwo = new Medicine("aspirin", 3);
            pillTwo.Count = 100;


            Medicine pillThree = new Medicine("Mezim", 2);
            pillThree.Count = 100;

            Medicine [] arrayofpills=new Medicine[3];
            arrayofpills[0] = pillOne;
            arrayofpills[1] = pillTwo;
            arrayofpills[2] = pillThree;
            


           foreach ( var i in arrayofpills)
            {
                Console.WriteLine(i);
            }



        }


    }
}
