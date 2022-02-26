using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//mdnde exe file niye aacilmirki
namespace NamespaceExp
{
    public class Off
    {
        public  int x;   // it should be static or not? why here is an mistake...

    }
    internal class Program
    {

    }
}

namespace NamespaceExp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("salam2");
            //NamespaceExp.Off.x = 5;
            //Console.WriteLine(NamespaceExp.Off.x);  // for static fields

            NamespaceExp.Off offfff = new NamespaceExp.Off();
            offfff.x = 10;
            Console.WriteLine(offfff.x);


        }
    }
}
