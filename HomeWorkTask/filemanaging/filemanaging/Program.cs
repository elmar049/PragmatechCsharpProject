using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filemanaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathh = @"C:\Users\elmar\Desktop\demo";

            var x = Directory.GetFiles(pathh);

            foreach (var f in x)
            {
                var o = new FileInfo(f);
                Console.WriteLine(o.Length);
            }
        }
    }
}
