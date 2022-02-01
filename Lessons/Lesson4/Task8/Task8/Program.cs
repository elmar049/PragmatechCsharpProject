using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 6, 7, 8, 23, 78, 34, 12 };
            #region 8.1
            //int res = 0;
            //foreach (var i in nums)            
            //{

            //    if (i % 2 == 1)
            //    {
            //        res = res + i;
            //    }


            //}
            //Console.WriteLine(res);  // tekleri uste uste gelmek
            #endregion


            #region 8.2

            //foreach (var x in nums)
            //{

            //    if (x % 3 == 0)
            //    {
            //        Console.WriteLine(x);
            //    }


            //}
            #endregion


            #region 8.4

            //Array.Sort(nums);
            //Array.Reverse(nums);
            //foreach (int i in nums)
            //Console.WriteLine(i);
            #endregion

            #region 8.3


            foreach (int i in nums)
            {
                if (i % 2 == 1)
                {
                    string x = $"{i}";
                    Console.WriteLine(x);
                }
            }
        }

    }

}
               
                
            
        #endregion







    




