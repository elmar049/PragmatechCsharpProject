using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Men man = new Men("elmar", "mammadov", 15, 5);
            man.GetFullInfo();
            
        }
    }
}
