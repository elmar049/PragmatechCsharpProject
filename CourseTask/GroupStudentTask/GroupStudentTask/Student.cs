using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupStudentTask
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public static int No=0;
        public int Siyahi;

        public Student(string ad, string familiya)
        {
            Name = ad;
            Surname = familiya;
            No++;
            Siyahi=No;
        }

    }
}
