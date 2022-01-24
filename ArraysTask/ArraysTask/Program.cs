using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArraysTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task2

            Queue reqemler = new Queue();
            Queue reqemler2 = new Queue();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Vvedite slovo: ");
                string x = Console.ReadLine();
                reqemler.Enqueue(x);

            }

            for (int j = 0; j < 4; j++)
            {
                reqemler2.Enqueue(reqemler.Dequeue());
            }



            Console.WriteLine("Your queue list if full, please write the last word which will replace the last index: ");
            string lastword = Console.ReadLine();
            reqemler2.Enqueue(lastword);


            foreach (var jjj in reqemler2)
            {
                Console.WriteLine(jjj);
            }
            #endregion









            #region Task 3


            List<int> mylist = new List<int>();
            List<int> mylist2 = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("type 10 different number");
                int x = Convert.ToInt32(Console.ReadLine());
                mylist.Add(x);
            }


            mylist2.Add(mylist[5]);
            mylist2.Add(mylist[6]);
            mylist2.Add(mylist[7]);
            mylist2.Add(mylist[8]);
            mylist2.Add(mylist[9]);

            mylist2.Add(mylist[0]);
            mylist2.Add(mylist[1]);
            mylist2.Add(mylist[2]);
            mylist2.Add(mylist[3]);
            mylist2.Add(mylist[4]);


            Console.WriteLine("Fokus mokus pokus ve budur:");
            foreach (int x in mylist2)
            {
                Console.WriteLine(x);
            }

            #endregion



            #region Task 4


            List<int> numbers = new List<int>();



            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("please insert the numbers: ");
                int xx = Convert.ToInt32(Console.ReadLine());
                numbers.Add(xx);

            }

            numbers.Sort();
            var MS = numbers.Distinct();

            int count = 0;
            foreach (int i in MS)
            {
                count++;
                Console.WriteLine($"{count}-ci element: " + i);
            }
            Console.WriteLine("Yalniz List Arraydan istfade olunub");
            Console.WriteLine("Rehman hediyemi gonder");
            #endregion



        }
    }
}
