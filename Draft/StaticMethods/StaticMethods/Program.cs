using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    //Static method sirtigdi
    internal class Program
    {
        static void Main(string[] args)
        {

            //MyClass2 obj1 = new MyClass2();
            MyClass3 myClass3 = new MyClass3(8);
            




        }
    }
    public class MyClass
    {
        public static int a = 5;
        public int b;


        public static void method2()
        {
            Console.WriteLine("static method");

            Console.WriteLine(a);

        }

        public void Method1()
        {
            Console.WriteLine("Non-Static method");
            Console.WriteLine(a);

        }


    }
    //COUNTER
    public class MyClass2
    {
        private static int _counter;

        public static int Counter
        {
            get { return _counter; }
           private set { _counter = value; }  //zdes mi piwem Private, ctobi 19 strochka bila nevozmojna, tak kak ona izmenaet smisl counta
        }

        public MyClass2()
        {
            Counter++;
            Console.WriteLine("salam");
        }
    }
    //STATIC CONSTTUCTION
    public class MyClass3
    {

        public MyClass3()
        {
            Console.WriteLine("salam");
        }
        public MyClass3(int a)
        {
            Console.WriteLine(a+5);
        }
        static MyClass3()
        {

        }


    }

    

}
