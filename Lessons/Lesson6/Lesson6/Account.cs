using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Account
    {
        public string Name;
        public string Password;
        public static int SnO = 0;
        public int No = 0;


        public Account(string ad, string parol)
        {
            Name = ad;
            Password = parol;
            SnO++;
            No = SnO;

        }



        public bool IsUserNameValid(string ad)
        {
            bool value=true;
            foreach (Char x in ad)
            {
                if (!Char.IsLetterOrDigit(x))
                {
                    value=false;
                }
                                 
            }
            
            return value;
        }


        
       





    }


       
    
}
