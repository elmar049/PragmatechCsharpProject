using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timer
{
    class VirtualCard
    {
        private long _cardnumber;
        //public double cash;
        //public int lifetime;

        public long cardnumber
        {
            get { return _cardnumber; }
            set
            {
                Random rd = new Random();
                string num = "";
                for(int i=0; i<16; i++)
                {
                   
                    int rand_num = rd.Next(0, 9);
                    
                    num = num + rand_num;
                }

                value = long.Parse(num);
                _cardnumber = value;


            }
        }



    }
}
