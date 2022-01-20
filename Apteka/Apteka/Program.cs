using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Apteka
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Aptek[] dermanlar = new Aptek[3];



            for (int i = 0; i < dermanlar.Length; i++)
            {
                Console.WriteLine("dermanin adin daxir et: ");
                string DermanAdi = Console.ReadLine();

                Console.WriteLine("dermanin sayini daxir et: ");
                int DermanSayi = Convert.ToInt32(Console.ReadLine());

                Aptek pill = new Aptek(DermanAdi, DermanSayi);

                dermanlar[i] = pill;

            }


            Added( ref dermanlar);
            foreach (var x in dermanlar)
            {
                Console.WriteLine("Pill name: " + x.Name+ " Pill's number: "+ x.Number);
            }
        }

        public static void Added(ref Aptek[] newList)
        {
            int say = 0;
            Console.WriteLine("Nece dene derman elave etmek isteyirsiniz?");
            int n=Convert.ToInt32(Console.ReadLine());  
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("yeni dermanin adin daxir et: ");
                string DermanAdiii = Console.ReadLine();

                Console.WriteLine("yeni dermanin sayini daxir et: ");
                int DermanSayiii = Convert.ToInt32(Console.ReadLine());

                for(int j = 0; j < newList.Length; j++)
                {
                    
                    if (DermanAdiii == newList[i].Name)
                    {
                        int x = 0;
                        x = newList[i].Number + DermanSayiii;
                        Console.WriteLine(newList[i].Name + " dermanindan " + DermanSayiii + " qeder artdi  ve" + x + "oldu");
                        newList[i].Number = x;  // ilk sef
                    }
                    else
                    {
                        say = say + 1;
                    }

                }
                if (say == newList.Length)
                {
                    Array.Resize(ref newList, newList.Length + 1);
                    Aptek yenipil = new Aptek(DermanAdiii, DermanSayiii);
                    newList[newList.Length-1] = yenipil;
                    //newList[i].Name = DermanAdiii;
                    //newList[i].Number = DermanSayiii;


                    Console.WriteLine(newList[newList.Length-1].Name + " dermanni  elave olundu ve sayida " + newList[newList.Length - 1].Number + " oldu");
                }
                say = 0;
                




            }
        }
    }
}


                
    





            
            

            
        
            #region ArrayList

            //ArrayList dermanlar = new ArrayList();
            //ArrayList saylari = new ArrayList();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Insert the name of pill");
            //    string dermanAdi = Console.ReadLine();
            //    Console.WriteLine("Insert the number of current pills");
            //    int dermanSayi = Convert.ToInt32(Console.ReadLine());


            //    dermanlar.Add(dermanAdi);
            //    saylari.Add(dermanSayi);



            //    Adding(dermanlar, saylari, dermanAdi, dermanSayi);

            //}


            //for (int k = 0; k<3; k++)
            //{
            //    Aptek pillOne=new Aptek(dermanlar[k], saylari[k]);
            //    Console.WriteLine(dermanlar[k] + " dermaninnan " + saylari[k] + " sayi qederdi");



            //}



            //Console.WriteLine("After creating Apteki, davayte provedem proverku Pillsov i ix nalichie");

            //Console.WriteLine("Yeni derman adini qeyd edin");
            //string yeniderman = Console.ReadLine();
            //Console.WriteLine("Sayini zehmet olmasa deyin");
            //int yenisay = Convert.ToInt32(Console.ReadLine());






        


        //public static void Adding(ArrayList one, ArrayList two,string adchik, int say)
        //{
        //    if ((string)one[1] == adchik)
        //    {
        //        say = say + two[1];
        //    }
        //}
        #endregion

        

