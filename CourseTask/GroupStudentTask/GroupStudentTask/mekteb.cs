using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupStudentTask
{
    internal class Mekteb
    {
        List<Group> mekteb = new List<Group>();
        public void Add(Group grup)
        {
            mekteb.Add(grup);
        }
        public void Cixartmagrup()
        {
            foreach (var grups in mekteb)
            {
                Console.WriteLine(Group.groupnum + " " + grups.Name);
            }
        }

        public void Cixartmawaqird()
        {
            foreach (var grups in mekteb)
            {
                grups.Cixartma();
            }
        }
        public void Elaveetme(string name, Student user)
        {
            foreach (var gruplar in mekteb)
            {
                if (gruplar.Name == name)
                {
                    gruplar.AddStudent(user);
                }
            }
        }
        public void Cixartmawaqird2(string namegrup)
        {
            foreach (var gruplar in mekteb)
            {
                if (gruplar.Name == namegrup)
                {
                    gruplar.Cixartma();
                }
            }
        }
    }
}
