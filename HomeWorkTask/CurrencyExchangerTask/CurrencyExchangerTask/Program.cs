using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }







    public class CurrencyExchanger
    {
        public CurrencyType type;
        public Dictionary<CurrencyType, double > currency;

    }
       

    public enum CurrencyType
    {
        USD,
        Eu,
        TL,
    }
}

