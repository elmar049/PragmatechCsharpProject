using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Random_password
{
    delegate int Mydelig(int x);
    class Program

    {
        public static void Foo(int y)
        {
            Console.WriteLine(y + 10);
        }

        public static void Foo1(int h)
        {
            Console.WriteLine(h - 10);
        }

        void Foo2(int y, int y2)
        {
            Console.WriteLine("eto foo 2");
        }

        void Foo3()
        {
            Console.WriteLine("eto foo bez parametrs");
        }
        static void Main(string[] args)
        {
            //var xxx = new Mydelig(Foo);
            //xxx += Foo1;
            //xxx(8);



            Mydelig xxkx = x => x * 6;

            Console.WriteLine(xxkx(5));





        }







    }


}
