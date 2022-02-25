using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Player player = new Player();
            //player.showall(new item1());

            //Ishowinfo info = new item1();
            //info.Data();


            Console.WriteLine("salam abiler");

            int a = 8;
            int b = 10;
            int c = a+b;
            Console.WriteLine(c);



        }
    }

    interface Ishowinfo
    {
        void Data();

    }

    class item1 : Ishowinfo
    {
        public void Data()
        {
            Console.WriteLine("data iz pervooq classa");
        }
    }



    class Player
    {
        public void showall(Ishowinfo xxx)
        {
            xxx.Data();
        }
    }


}
