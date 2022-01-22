using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book[] kitablar = new Book[0];

            //Book kitab1 = new Book("Ali Nino", 68);
            //kitablar[0] = kitab1;

            Adding(ref kitablar);




            foreach (var x in kitablar)
            {
                Console.WriteLine("kitabin adi: " + x.Name + ". KItabin sehifesi: " + x.PageNumber);
            }


        }
        public static void Adding(ref Book[] knijki)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Please insert the book number (Min 3 symbols): ");
                string BookName = Console.ReadLine();

                Console.WriteLine("Please insert the number of page of book(Min 10 pgs): ");
                int BookPage = Convert.ToInt32(Console.ReadLine());

                if (BookName.Length > 3 && BookPage > 10 && knijki.Length<10)
                {
                    Array.Resize(ref knijki, knijki.Length + 1);
                    Book bookobject = new Book(BookName, BookPage);
                    knijki[knijki.Length-1] = bookobject;
                }
                else if (knijki.Length >= 10)
                {
                    Console.WriteLine("Sizin limitiniz doldu");

                    break;
                }
                else
                {
                    Console.WriteLine("Something get wrong, please pay attention to the condition, Try again!");
                }

            }

        }

    }

}
