using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Student
    {
        public string FullName;
        public int GroupNo;
        public int Age;

        public Student(string tamAd, int qrup, int yash)
        {
            FullName = tamAd;
            GroupNo = qrup;
            Age = yash;

        }

        public void GetBirthYear(Student student)
        {
            int datebirth = DateTime.Now.Year - student.Age;
            Console.WriteLine(datebirth);
        }

        //ctor
    }
}
 