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
            MyClass obj=new MyClass();
            MyClass.a = 8;  //odin raz izmeni i vse on vezde 8

            Console.WriteLine(MyClass.a);
            MyClass.method2();

            obj.Method1();





            //MyClass.method2();

        }
    }
    public class MyClass
    {
        public static int a=5;
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
}
