using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupStudentTask
{
    internal class Group
    {
        public static int groupnum = 100;
        public int Count;
        public string Name;
        List<Student> qruppaname = new List<Student>();
        public Group(string name, int count)
        {
            Name = name;
            Count = count;
            groupnum += 1;
        }
        public void AddStudent(Student user)
        {
            qruppaname.Add(user);
        }
        public void Cixartma()
        {
            foreach (var grup in qruppaname)
            {
                Console.WriteLine(Student.No + " " + grup.Name + " " + grup.Surname);
            }
        }

    }
}
