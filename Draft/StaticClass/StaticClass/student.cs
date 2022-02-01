using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Student
    {
        private string _Name;
        private string _surName;
        private int _Age;
        private DateTime _Birth;



        public Student(string name, int age)
        {
            _Name= name;
            _Age= age;  
        }



        public Student(string name, string sruname, int age, DateTime birth): this(name, age)
        {
            //_Name = name;
            _surName= sruname;
            //_Age = age;
            _Birth= birth;
            
        }



        public Student(Student telebe)
        {
            _Name = telebe._Name;
            _surName = telebe._surName;
            _Age = telebe._Age;
            _Birth = telebe._Birth;

        }

        public string ChangeSurname(string x)
        {
            this._surName = x;
            return _surName;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {_Name} \nSurname: {_surName} \n{_Age} \n{_Birth} ");
        }





    }

}
        


   



