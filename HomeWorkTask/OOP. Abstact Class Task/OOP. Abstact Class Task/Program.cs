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
            Console.WriteLine("Insert your full name: ");
            string _fullname=Console.ReadLine();

            Console.WriteLine("Insert your e-mail: ");
            string _email=Console.ReadLine();

            Console.WriteLine("Insert your password");
            string _password=Console.ReadLine();

            user user = new user();
            user.FullName = _fullname;
            user.Email = _email;
            user.Password = _password;



            //user.ShowInfo();
            //Console.WriteLine("Your pass is " + user.PasswordChecker(user.Password));



            user.ShowInfo();
            user.PasswordChecker2();

        }
    }
}
