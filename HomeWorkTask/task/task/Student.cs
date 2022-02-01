using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public int Age;
        public static int Cnt;
        public int say;
        public List<Student> students; 

        public Student(string ad, string soyad, int yas)
        {
            students = new List<Student>();
            Name =ad;
            Surname=soyad;
            Age=yas;
            Cnt++;
            say = Cnt;
            Console.WriteLine($"{say}-nci adam qyediyatdan kewdi");
        }

        public void AddStudent(Student telebeler)
        {
            foreach(var xxx in students)
            {
                if (xxx.Name != telebeler.Name)
                {
                    students.Add(telebeler);
                }
                else
                {
                    Console.WriteLine("Bu ad uje daxil edilib");
                }
            }
            
        }

    }
}
