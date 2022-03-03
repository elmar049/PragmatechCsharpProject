using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a=new UserClass { userName = "elmar", userSurname = "memmedov" };

            Console.WriteLine(a.userName);
          
        }

        internal class UserClass
        {
            public string userName { get; set; }
            public string userSurname { get; set; }
           
        }

    }
}
