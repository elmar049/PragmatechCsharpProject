using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student("elmar", 28);
            //std.Print();




            Student std2 = new Student("qusik", "mammadov", 28, new DateTime(1993, 08, 23));
            Student std3 = std2; // eto dva ssilochnie tipi dannix, kotoroe otnosyatda k odnomu istochniku...esli izmenaetsa odin to i izmenaetsa vtoroy
            std2.ChangeSurname("huseynov");


            std2.Print();
            std3.Print(); // zdes u oboix budet familiya HUSEYNOV





            //no ESLI
            Student std4 = new Student("vasif", "mammadov", 28, new DateTime(1993, 08, 23));
            Student std5 = new Student(std4);
            std4.ChangeSurname("aliyeba");

            std4.Print();
            std5.Print();  // to zdes familiyii budu raznie, tak kak na 33 stroke mi sozdali dlya ref osoboe mesto v Ram pamyati, ctob oni ne menyaslis


            Student test = new Student("hadi", "amirov", 14, new DateTime(2000, 12, 12));
            test.Print();





            
        }
    }
}
