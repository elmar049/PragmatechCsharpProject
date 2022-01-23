using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1) Aşağıdaki tapşırığı yerinə yetirin:
//a) Key və value-su string tipində olan Dictionary yaradın.

//b) İstifadəçidən 10 dəfə iki söz yazılması istənilsin:

//b .1) Birinci söz ölkə adı. b.2) İkinci söz paytaxt adı.

//c) Daha sonra istifadəçi ölkə adı yazaraq daxil edilən list-dən paytaxt adını almalıdır.

//d) Əgər istifadəçi ölkə adı əvəzinə "all" sözü daxil edilərsə, dictionary-də olan bütün ölkə-paytaxlar print edilsin.

//e) Nəticəni aldıqdan sonra yeni paytaxt axtarışı edilsin yoxsa proqram bitsin deyə istifadəçidən soruşulmalıdır və cavaba müvafiq əməliyyat baş verməlidir.

//Misal üçün:

//Proqram çalışarkən aşağıdakilər baş verməlidi:

//Əvvəl belə mesaj çıxır: "Hörmətli istifadəçi! Zəhmət olmasa ölkə adı qeyd edin."

//Daha sonra ölkə adını yazmaq istənilir.

//Daha sonra bu mesaj çıxır: "Hörmətli istifadəçi! Zəhmət olmasa ölkəyə aid paytaxt qeyd edin."

//Paytaxt adını yazmaq istənilir.

//Bütün bu proses 10 dəfə təkrarlanır və dictionary dolur. Daha sonra istifadəçidən bir ölkə adı yazmaq istənilir:

//"Hörmətli istifadəçi! Zəhmət olmasa paytaxtını tapmaq istədiyiniz ölkənin adını qeyd edin."

//İstifadəçi "Azərbaycan" yazarsa dictionary-də həmin key-ə görə search edib, ona uyğun value-nu, yəni "Bakı" sözünü qaytarıb, ekrana print etmək lazımdı. Əgər istifadəçi ölkə adı əvəzinə "all" sözü daxil edilərsə, dictionary-də olan bütün ölkə-paytaxlar print edilsin.

//Print etdikdən sonra soruşulur: "Yeni paytaxt axtarılsın? Y/N"

//İstifadəçi "Y" yazarsa yeni axtarış üçün ölkə adı istənilsin, "N" basarsa proqramdan çıxsın.


namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cities = new Dictionary<string, string>();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Please write country: ");
                string country = Console.ReadLine();

                Console.WriteLine("Please write the capital of current country: ");
                string city = Console.ReadLine();

                cities.Add(country, city);


            }

            string yes = "Yes";
            string no = "No";


            Console.WriteLine("Please write a country's name whose capital you want to get: ");
            string selected = Console.ReadLine();
            foreach (var item in cities)
            {
                if (selected == item.Key)
                {
                    Console.WriteLine("Regarding to you option, the capital of chosen country is going to be: " + item.Value);
                }
                else if (selected == "all")
                {
                    Console.WriteLine($"Country Name: {item.Key}. Country's Capital: {item.Value}");
                }
            }

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Do you want to continue your research: Yes/No");
                string reply = Console.ReadLine();
                if (reply == yes)
                {
                    Console.WriteLine("Please write a country's name whose capital you want to get: ");
                    string selected2 = Console.ReadLine();

                    foreach (var item in cities)
                    {
                        if (selected2 == item.Key)
                        {
                            Console.WriteLine("Regarding to you option, the capital of chosen country is going to be: " + item.Value);
                        }
                        else if (selected2 == "all")
                        {
                            Console.WriteLine($"Country Name: {item.Key}. Country's Capital: {item.Value}");
                        }
                    }
                }
                if (reply == no)
                {
                    Console.WriteLine("Thank you for using our app");
                    break;
                }





            }



















        }
    }
}
