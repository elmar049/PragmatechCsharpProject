
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] strs = { "Vaaaaaaaaaal", "Vaaal", "Val", "Vaaa" };

            Console.WriteLine(Nese(strs));



            //sual 1: niye  39cu setride biz Substring eleyirik, ve sonra hemen substringi call edende 
            //ferqli olur, amma menim examplimimpada eyni olur?
            string y = "elmar";
            Console.WriteLine(y);
            y.Substring(0, 2);
            Console.WriteLine(y);

            //sual 2:
            //w ferqi varki men burda return eledim yoxsaki Void ile verdim, eyni sheyi men burda CW verdim amma eror verdi;


        }
        public static string Nese (string [] strs)
        {
            for (int i = 0; i < strs[0].Length; i++)
            {
                char tmpChar = strs[0][i];
                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j].Length == i || strs[j][i] != tmpChar)
                    {
                        return strs[0].Substring(0, i);


                    }
                    
                }
            }
            return strs[0];

        }
    }
}
