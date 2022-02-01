using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetInheritence
{
   abstract class Student  // zdes est Abstarct, poetomu mi ne mojem sozdat obyekt
    {       
        public string Name;
        public string Surname;
        public int Age;

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public  virtual void GetFullInfo()
        {
            Console.WriteLine(Name + " " + Surname);
        }
    }

    class Girls: Student
    {
        public int HairLength;

        public Girls(string ad, string soyad, int sacuzunlugu): base(ad, soyad)
        {
            HairLength = sacuzunlugu;
        }
    }

    class Men: Girls
    {
        public int BeardLength;

        public Men(string add, string soyadd, int sacuzuluguu, int sakkal): base(add, soyadd, sacuzuluguu)
        {
            BeardLength = sakkal;
        }

        public override void GetFullInfo()
        {
            Console.WriteLine(this.Name + " " + this.Surname + " ve sakkal uzunlugu " + BeardLength);
        }
    }
}
