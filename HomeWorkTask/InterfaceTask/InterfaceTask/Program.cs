using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            double summa = calculate.sum(30.4, 20.6, 70.3);
            double vicitanie = calculate.minus(20.1, 10, 5);
            double umj = calculate.umnojenie(5, 4.5, 3);
            double del = calculate.delenie(100, 20, 2);


            Console.WriteLine(summa + " ; " + vicitanie + " ; " + umj + " ; " + del);
        }
    }

    interface Isum
    {
        double sum(params double[] numbers);
    }
    interface IMultiply
    {
        double umnojenie(params double[] numbers);
    }
    interface IDifference
    {
        double minus(params double[] numbers);
    }
    interface IDivide
    {
        double delenie(params double[] numbers);
    }

    public class Calculate : Isum, IMultiply, IDivide, IDifference
    {
        public double delenie(params double[] numbers) // i want to add that this part of code a bit unuseful
        {
            double res = 1;

            for (int k = 0; k < numbers.Length; k++)
            {
                res = res / numbers[k];
            }

            return res;

        }

        public double minus(params double[] numbers)
        {
            double res = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                res = res - numbers[i];
            }
            return res;
        }

        public double sum(params double[] numbers)
        {
            double res = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                res = res + numbers[i];
            }
            return res;
        }

        public double umnojenie(params double[] numbers)
        {
            double res = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                res = res * numbers[i];
            }
            return res;
        }
    }
}
