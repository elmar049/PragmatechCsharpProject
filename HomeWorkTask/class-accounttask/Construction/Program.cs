using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("elmar", "compaq23081993ea");
            //Console.WriteLine(acc1.isPasswordValid("ff#%#$h2&Hfru"));
            Console.WriteLine(acc1.IsUserNameValid("s8de#$dsb"));
        }

    }
}
