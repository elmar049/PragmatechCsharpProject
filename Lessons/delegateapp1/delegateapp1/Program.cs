using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateapp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "Bir", "Iki", "uc", "offFffff",
            };


            

            fiteryap3(list);

            foreach (var item in fiteryap3(list))
            {
                Console.WriteLine(item);
            }

        }

        public static List<string> fiteryap1(List<string> xxx)
        {
            List<string> newlst = new List<string>();
            foreach (var lis in xxx)
            {
                if (lis.Count() >= 5)
                {
                    newlst.Add(lis);
                }

            }
            return newlst;
        }



        public static List<string> fiteryap2(List<string> xxx)
        {
            List<string> newlst = new List<string>();
            foreach (var lis in xxx)
            {
                if (char.IsUpper(lis.ToCharArray().First()))
                {
                    newlst.Add(lis);
                }

            }
            return newlst;
        }


        public static List<string> fiteryap3(List<string> xxx)
        {
          
            List<string> newlst = new List<string>();
            foreach (var lis in xxx)
            {
                if (lis.Contains('e'))
                {
                    newlst.Add(lis);
                }
                
            }

            return newlst;
        }

        public static List<string> fiteryap4(List<string> xxx)
        {

            List<string> newlst = new List<string>();
            
            foreach (var lis in xxx)
            {
                foreach (var lis2 in lis)
                {
                    if (char.IsUpper(lis2))
                    {
                        newlst.Add(lis);
                    }
                }
                
            }

            return newlst;
        }




    }
}
