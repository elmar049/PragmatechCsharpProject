
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            List<string> list = new List<string>()
            {
                "Elmar", "Elman", "Elxan", "Ekber", "Saleh"
            };

            List<string> newlist = new List<string>();

            

            for (int y = 0; y < list.Count; y++)
            {
                for(int x = 0; x < list[y].Length; x++)
                {
                  if(list[y][x] == list[x])
                    
                }
                
            }




           

           

        }
    }
}
