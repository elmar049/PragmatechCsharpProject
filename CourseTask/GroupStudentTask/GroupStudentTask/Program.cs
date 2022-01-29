using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupStudentTask
{
    internal class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine(" Bunlardan birini sec:  \n 1- yeni telebe yarat \n 2 - yeni qrup yarat \n 3 - telebenin siyahisini goster \n 4 - qruplarin siyahisini goster \n 5 - qrupa telebe elave et \n 6 - secilmis qrupdaki telebeleri goster \n 7 - sistemden cix");
            string secim = Console.ReadLine();
            Mekteb school = new Mekteb();
            Student user = new Student("Aysel", "Mustafayeva");
            Group grup = new Group("K172", 8);
            while (secim != "7")
            {
                if (secim == "1")
                {
                    Console.WriteLine(" Studentin Adini dahil et: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Familiyasini dahil et: ");
                    string surname = Console.ReadLine();
                    user = new Student(name, surname);
                    Console.WriteLine("Grup yaranmiyibsa dahil etmek ucun, tezesini yarat, \n yaranibsa qrupu sec(5-e basib) ve dahil et");

                }
                else if (secim == "2")
                {
                    Console.WriteLine("Grupun adini dahil et: ");
                    string grupname = Console.ReadLine();
                    Console.WriteLine("Qrupun sayini dahil et: ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    grup = new Group(grupname, count);
                    Console.WriteLine("Evvel yaratdiqin useri dahil etmek istiyirsen?(Y/N)");
                    string secim2 = Console.ReadLine();
                    if (secim2 == "Y")
                    {
                        grup.AddStudent(user);
                    }
                    school.Add(grup);
                }
                else if (secim == "3")
                {
                    school.Cixartmawaqird();
                }
                else if (secim == "4")
                {
                    school.Cixartmagrup();
                }
                else if (secim == "5")
                {
                    Console.WriteLine("Olan qrupun adini dahil et:  ");
                    string ad = Console.ReadLine();
                    Console.WriteLine(" Evvel yaratdiqin userdi yoxsa teze yaradassan(teze/evvel)");
                    string dahilete = Console.ReadLine();
                    if (dahilete == "evvel")
                    {
                        school.Elaveetme(ad, user);
                    }
                    else
                    {
                        Console.WriteLine(" Studentin Adini dahil et: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Familiyasini dahil et: ");
                        string surname = Console.ReadLine();
                        user = new Student(name, surname);
                        school.Elaveetme(ad, user);
                    }
                }
                else if (secim == "6")
                {
                    Console.WriteLine("Grupun adini dahil et: ");
                    string adi = Console.ReadLine();
                    school.Cixartmawaqird2(adi);
                }
                Console.WriteLine(" Bunlardan birini sec:  \n 1- yeni telebe yarat \n 2 - yeni qrup yarat \n 3 - telebenin siyahisini goster \n 4 - qruplarin siyahisini goster \n 5 - qrupa telebe elave et \n 6 - secilmis qrupdaki telebeleri goster \n 7 - sistemden cix");
                secim = Console.ReadLine();
            }
        }
    }




    //Console.WriteLine(" 1 - yeni qrup yarat \r\n 2 - yeni telebe yarat \r\n 3 - telebenin siyahisini goster \r\n 4 - qruplarin siyahisini goster \r\n 5 - qrupa telebe elave et r\n 6 - secilmis qrupdaki telebeleri goster r\n 7 - sistemden cix");

    //int input = Convert.ToInt32(Console.ReadLine());



    //while (input != 7)
    //{
    //    if (input == 1)
    //    {
    //        Console.WriteLine("Please insert the number of groups you want to add: ");
    //        int y = Convert.ToInt32(Console.ReadLine());
    //        for (int j = 0; y < j; j++)
    //        {
    //            Console.WriteLine("Insert groups's name: ");
    //            string groupname = Console.ReadLine();

    //            Console.WriteLine("Please insert the capacity of group");
    //            int kap = Convert.ToInt32(Console.ReadLine());

    //            Goup grup1 = new Goup(groupname, kap);
    //        }




    //    }


    //    if (input == 2)
    //    {
    //        Console.WriteLine("Please insert the number of student you want to add: ");
    //        int x = Convert.ToInt32(Console.ReadLine());

    //        for (int i = 0; i < x; i++)
    //        {
    //            Console.WriteLine("Insert Student's name: ");
    //            string name = Console.ReadLine();

    //            Console.WriteLine("Insert Student's surname: ");
    //            string surname = Console.ReadLine();

    //            Student std1 = new Student(name, surname);



    //        }
    //    }





















}
  
