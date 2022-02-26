using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligate
{
    internal class Program
    {
        public delegate void MutualFormula(List<int>xxx);
        static void Main(string[] args)
        {
            List <int> nums=new List<int>() {3,5,34,11,53,23,43,12,44,19,33 };

            divide5(nums);
            dividenone(nums);
            nechetnie(nums);



            MutualFormula newdel=new MutualFormula(dividenone);


            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    int x=nums[i];
                }
                
            }



        }
        public static void dividenone(List<int> nums)
        {
            for(int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    Console.WriteLine("chetnie " + nums[i]);
                }
            }
          
        }

        public static void divide5(List<int> nums, )
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 5 == 0)
                {
                    Console.WriteLine("na 5 delyatsa " + nums[i]);
                }
            }

        }

        public static void nechetnie(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    Console.WriteLine("nechenie " + nums[i]);
                }
            }

        }

        
    }
}
