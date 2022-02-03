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


        //public abstract bool PasswordChecker(string pass);

        public abstract void PasswordChecker2();  //Aysel style
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

        //public override bool PasswordChecker(string pass)
        //{

        //    bool x = false;
        //    bool y = false;
        //    bool a = false;


        //    if (pass.Length > 8)
        //    {
        //        x = true;
        //    }

        //    if (x)
        //    {
        //        char[] xxx = pass.ToCharArray();
        //        foreach (char c in xxx)
        //        {

        //            if (char.IsUpper(c)) 
        //            {
        //                y = true;

        //            }
        //            else if (char.IsLower(c) && y)
        //            {
        //                a = true;
        //            }
        //        }
        //    }

        //    return a;
        //}

        public override void PasswordChecker2()
        {
            int biglet = 0;
            int smalllet = 0;
            if (this.Password.Length > 8)
            {
                char[] chars = this.Password.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (char.IsUpper(chars[i]))
                    {
                        biglet++;
                    }
                    if (char.IsLower(chars[i]))
                    {
                        smalllet++;
                    }
                }
                if (biglet < chars.Length && smalllet < chars.Length && biglet != 0 && smalllet != 0)
                {

                    Console.WriteLine("You pass is okay");
                }
                else
                {
                    Console.WriteLine("Your pass is wrong");
                }


            }
            else
            {
                Console.WriteLine("Your pass is wrong");

            }
        }
    }
}



