using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedTwoClasses
{
    internal class Grouping
    {
        public string GroupName;
        public Ixtisislar type;
        public List<Student> telebeler = new List<Student>();


        public Grouping(Ixtisislar tipi, string qrupadi)
        {
            type=tipi;
            GroupName=qrupadi;
        }


        public void AddStudent(Student std)
        {
            telebeler.Add(std);
        }

    }

    public enum Ixtisislar
    {
        Math,
        History
    }
}
