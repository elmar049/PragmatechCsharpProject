using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student [] obyetler= new Student[3];

            for (int i=0; i < obyetler.Length; i++)
            {
                Console.WriteLine("Please insert your full name");
                string polnoeImya = Console.ReadLine();


                Console.WriteLine("Please insert your Group Number: ");
                int qrupNomresi =Convert.ToInt32(Console.ReadLine());




                Console.WriteLine("Please insert your age: ");
                int yas = Convert.ToInt32(Console.ReadLine());


                Student student = new Student(polnoeImya, qrupNomresi, yas);

                student.GetBirthYear(student);

                obyetler[i] = student;

            }

            foreach (var y in obyetler)
            {
                Console.WriteLine(y.FullName + " " + y.GroupNo + " "+ y.Age);

            }

            


        }

        

    }
}
 