using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketTask
{
    internal class item
    {
        public string Name;
        public double Price;
        public int Number;

        public item(string ad, double qiymet, int say)
        {
            Name = ad;
            Price = qiymet;
            Number = say;

        }

    }
}
