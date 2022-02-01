using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstact_Class_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            user user = new user();
            user.FullName = "Elmar Mammadov";
            user.Email = "mammadovelmar93@gmail.com";
            user.Password = "JSJSJSJJaJJJJ";



            user.ShowInfo();
            Console.WriteLine("Your pass is " + user.PasswordChecker(user.Password));

        }
    }
}
