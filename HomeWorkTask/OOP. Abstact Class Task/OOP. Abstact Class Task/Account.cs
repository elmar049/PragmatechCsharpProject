using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstact_Class_Task
{
    abstract class Account
    {
        public string FullName;
        public string Email;
        public string Password;


        public abstract bool PasswordChecker(string pass);
        public virtual void ShowInfo()
        {
            Console.WriteLine(FullName + " " + Email);
        }
    }

    class user : Account
    {
        public override void ShowInfo()
        {
            Console.WriteLine($"Full Name is gonna be: {this.FullName} \nMail is: {this.Email} ");
        }

        public override bool PasswordChecker(string pass)
        {

            bool x = false;
            bool y = false;
            bool a = false;


            if (pass.Length > 8)
            {
                x = true;
            }

            if (x)
            {
                char[] xxx = pass.ToCharArray();
                foreach (char c in xxx)
                {
                    
                    if (char.IsUpper(c)) 
                    {
                        y = true;
                       
                    }
                    if (char.IsLower(c) && y)
                    {
                        a = true;
                    }
                }
            }

            return a;
        }


    }
}

