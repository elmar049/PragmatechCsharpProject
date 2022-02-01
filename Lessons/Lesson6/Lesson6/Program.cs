using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;



namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string x = "5.5";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double y=Convert.ToDouble(x, numberFormatInfo);
            Console.WriteLine(y);
                

            //Cars2.AufMethod(word);

            //Cars.Fullname(word, word2, word3);

        }
    }
}



















