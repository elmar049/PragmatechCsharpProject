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
            //string pathh = @"C:\Users\elmar\Desktop\demo";



            //var filecollection = Directory.GetFiles(pathh, "*", SearchOption.AllDirectories);

            //foreach (var file in filecollection)
            //{
            //    var x1=Path.GetFileName(file);
            //    var x2=Path.GetFileNameWithoutExtension(file);
            //    var x3=Path.GetExtension(file);
            //    var o = new FileInfo(file);

            //    Console.WriteLine(o.Length);
            //}


            // creation of dirc
            //string newpathh = @"C:\Users\elmar\Desktop\demo\sikdirrrr\kkkk\vvv\lll";

            //Directory.CreateDirectory(newpathh);

            //var x= Directory.GetDirectories(pathh);

            //foreach(string s in x)
            //{
            //    Console.WriteLine(s);
            //}





            //rename of dir
            //string first = @"C:\Users\elmar\Desktop\demo\newpath2222";
            //string second = @"C:\Users\elmar\Desktop\demo\papkaBb";
            //Directory.Move(first, second);

            //FILES//


            //string [] files = Directory.GetFiles(pathh);

            //string destination = @"C:\Users\elmar\Desktop\demo\sikdir\got.txt";

            //foreach (string file in files)
            //{

            //    File.Copy(file, $"{destination}", true);

            //    Console.WriteLine(Path.GetFileNameWithoutExtension(file));


            //}



            //creation

            string path = @"C:\Users\elmar\Desktop\demo\kkkkkkk.txt";

            TextWriter tw = new StreamWriter(path, true);
            tw.WriteLine("vecna");
            tw.Close();

            //readfile

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

        }
    }
}
