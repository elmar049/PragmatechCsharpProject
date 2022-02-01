using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public static class Cars
    {
        public static string Name;
        public  static string Color;
        public static int Year;


        //public static  Cars ()
        //{
        //    Name = imya;
        //    Color = cvet;
        //}

        public static void  Fullname(string xx, string yy,string zz)
        {
            Console.WriteLine("aye" +xx+yy+zz) /*this.Name + " imeet cvet " + this.Color + " kotoriy " + this.Year + " qoda"*/;
        }
    }

    public static class Cars2
    {
        
        public static void AufMethod(string x)
        {
            Console.WriteLine(x+ "adam qehbe olmaz");
        }
    }
}




// 1) Koqda mi pishem public STATIC void, eto znachit mi mojem call Class, ne sozdavaya eqo object ---
// t.e koqda uje est slovo static,znachit dlya neqo uje est mesto v RAM-e; + koqda method bez STATIC: no on individualen dlya kajdoqo obyekta
//  i ctobi vizvat uje method bez  STATIC, to mi doljni budet sperva sozdat object, OBJEKTLE BAGLI NESE VAR

// STATIC classdan objekt yaratmaq olmur... Static olanda, onun uje ramda yeri olduguycun, onun icindeki metoduda uje cagirmaq olur: neceki math.maxsize falan


//koqda mi sozdaem Class, to tam mojno i ne pisat STATIC, no vnutri eqo v eqo methodan: tam STATIC doljno bit, ctob mojno bilo
// leqko napisat imya class i method... Cars.Fullname()


// 2) No esli, nash CLASS with STATIC, everything within CLASS should has STATIC (methods, constructions, params)...
//esli CLASS STATIC, to posledwuyie bez static ne rabotaut voosbbe


//3) esli u nas class bez static, i odin parametr STATIC, kak dopustim avtoscetchik: eqo nelzya vizvat, tak kak uje est sozdanniy objet...


//4) Static construction: eto cto proisxodit perviy raz i odnajdi...bir defe iwleyir ve birincu... BIRINCI defe object  yararnanda iwleyir