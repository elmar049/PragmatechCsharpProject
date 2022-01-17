using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    internal class Account
    {

        public string Login;
        public string Password;

        public Account(string adin, string parol)
        {
            Login = adin;
            Password = parol;
        }



        public bool IsUserNameValid(string login)
        {

           bool value = true;
            
           for (int x=0; x<login.Length; x++)
            {   

                if (!Char.IsLetterOrDigit(login[x]))
                {
                    value = false;
                }
                
                    
            }

                return value;
         }


           
        
         public bool isPasswordValid( string input)
         {
            bool symb = false;
            bool symb2=false;
            bool symb3=false;
            bool symb4=false;
            

            if (input.Length>=8 && input.Length <= 25)
            {
                symb = true;
                
            }


            string symbols = "!@#$%^&*()_-+=[{]};:<>|./?.";
            char[] sym = symbols.ToCharArray();
            char[] CharInput = input.ToCharArray();
            
            char currentchar;


            char[] digits = "0123456789".ToCharArray();
            
            if (symb)
            {
                for (int i = 0; i < CharInput.Length; i++)
                {
                    currentchar = CharInput[i];

                    foreach (char c in CharInput)
                    {
                        
                        if ( char.IsUpper(c) )
                        {
                            symb2 = true;
                        }
                    }

                    
                    if (symb2)
                    {
                        foreach (var k in sym)
                        {

                            if (k == currentchar)
                            {

                                symb3 = true;

                            }
                        }

                    }

                    if (symb3)
                    {
                        foreach (var v in digits)
                        {
                            if (v == currentchar)
                            {
                                symb4 = true;
                            }
                        }
                    }

                }

            }
            
            return symb4;    
                    
               





         }

            


    }   



}

    



