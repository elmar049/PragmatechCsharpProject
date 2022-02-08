using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {


            NefteGunu xxx = NefteGunu.sreda;


            Console.WriteLine(xxx);
            Console.WriteLine((int)xxx);



            NefteGunu thenextday = TheND(xxx);
            Console.WriteLine(thenextday);




        }


        static NefteGunu TheND(NefteGunu gun)
        {
            if (gun < NefteGunu.vosk)
            {
                return gun + 1;
            }
            else
            {
                return NefteGunu.ponedelnik;
            }


        }

        enum NefteGunu
        {
            ponedelnik = 1,
            vtornik,
            sreda,
            cetverq,
            pyatnica,
            subbota,
            vosk

        }
    }

}
