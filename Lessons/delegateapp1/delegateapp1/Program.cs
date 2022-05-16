using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateapp1
{
    internal class Program
    {
        /* public delegate List<string> XXX(int x);*/ // bu yaratdigmiz trubada yani pipelne gondere bileceymizi METHODLARIN OSOSBIY XSUSIYETLERI OLMALLIDI
                                                      // 3CU SOZ O DEMEKDIKI HEMEN O METHODUNUN RETUNR TIPI NEDIR, PARAMETR INT X-ISE HEMEN METHON NE QEBUL EDECEYNI DEYIR0

        public delegate bool xxx(string xxx);

        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "Bir", "Iki", "hhjnnjnjnjnjnuc", "offFffff",
            };

            //var newDELFOO = new xxx(app1);
            //newDELFOO += app2;
            //newDELFOO(20);

            //Console.WriteLine(newDELFOO(20));



            xxx yenidel = filterrr;
            yenidel+=

            //fiteryap3(list);

            //foreach (var item in fiteryap3(list))
            //{
            //    Console.WriteLine(item);
            //}


            var a = fiteryap4(yenidel, list);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }


            
        }

        public static bool filterrr(string itemm)
        {
            return itemm.Count() > 4;
        }

        public static bool filterrr2(string itemm)
        {
            return itemm.Count() > 4;
        }


        //public static int app1(int h)
        //{
        //    return h + 2;
        //}

        //public static int app2(int h)
        //{
        //    return h - 2;
        //}



        //public static List<string> fiteryap1(List<string> xxx)
        //{
        //    List<string> newlst = new List<string>();
        //    foreach (var lis in xxx)
        //    {
        //        if (lis.Count() >= 5)
        //        {
        //            newlst.Add(lis);
        //        }

        //    }
        //    return newlst;
        //}



        //public static List<string> fiteryap2(List<string> xxx)
        //{
        //    List<string> newlst = new List<string>();
        //    foreach (var lis in xxx)
        //    {
        //        if (char.IsUpper(lis.ToCharArray().First()))
        //        {
        //            newlst.Add(lis);
        //        }

        //    }
        //    return newlst;
        //}


        //public static List<string> fiteryap3(List<string> xxx)
        //{

        //    List<string> newlst = new List<string>();
        //    foreach (var lis in xxx)
        //    {
        //        if (lis.Contains('e'))
        //        {
        //            newlst.Add(lis);
        //        }

        //    }

        //    return newlst;
        //}

        //public static List<string> fiteryap4(List<string> xxx)
        //{

        //    List<string> newlst = new List<string>();

        //    foreach (var lis in xxx)
        //    {
        //        foreach (var lis2 in lis)
        //        {
        //            if (char.IsUpper(lis2))
        //            {
        //                newlst.Add(lis);
        //            }
        //        }

        //    }

        //    return newlst;
        //}




        public static List<string> fiteryap4(xxx del, List<string> hhh)
        {

            List<string> newlst = new List<string>();

            foreach (var lis in hhh)
            {

                if (del(lis))
                {
                    newlst.Add(lis);
                }


            }

            return newlst;
        }



    }
}
