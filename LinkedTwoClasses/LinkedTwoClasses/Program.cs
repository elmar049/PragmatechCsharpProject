using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using LinkedTwoClasses;


namespace LinkedTwoClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grouping group1 = new Grouping(Ixtisislar.Math, "Riyazetchiler");
            Grouping group2 = new Grouping(Ixtisislar.History, "Tarixciler");



            Student telebe1 = new Student("Elvira", "Huseynova");
            Student telebe2 = new Student("Elmar", "Mamedov");
            Student telebe3 = new Student("Elvira", "Medetovna");
            Student telebe4 = new Student("Vasif", "Huseynova");
            Student telebe5 = new Student("Rehman", "Ferzeliyeb");
            Student telebe6 = new Student("Zilfeli", "HEmivod");
            Student telebe7 = new Student("Ravi", "HEsenova");
            Student telebe8 = new Student("Telman", "MEhdtiyeva");


            group1.AddStudent(telebe1);
            group1.AddStudent(telebe2);
            group1.AddStudent(telebe3);
            group1.AddStudent(telebe4);
            group2.AddStudent(telebe5);
            group2.AddStudent(telebe6);
            group2.AddStudent(telebe7);
            group2.AddStudent(telebe8);

            foreach (var item in group1.telebeler)
            {
                Console.WriteLine(item.Name + " " + item.Surname + " studied in Math group, they group is called:  " + group1.GroupName);
            }

            foreach (var itemm in group2.telebeler)
            {
                Console.WriteLine(itemm.Name + " " + itemm.Surname + " studied in History group, they group is called:  " + group2.GroupName);
            }









        }
    }
}
