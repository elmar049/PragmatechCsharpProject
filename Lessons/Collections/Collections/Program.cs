using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





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
