using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackHeap
{
    public abstract class Vehicle
    {
        public string Color;
        public string Brand;
        public double Milage;

        public Vehicle(string reng, string model, double prabeq)
        {
            Color = reng;
            Brand = model;
            Milage = prabeq;
        }


        public virtual void ShowAllInfo()
        {
            Console.WriteLine($"THe colour of car is {Color}, and its brand is {Brand} with milage {Milage}km");
        }

        public abstract void Drive(int distance);

    }

    public class Car : Vehicle
    {
        public double FuelCapacity;
        public double CurrentFuel;
        public double FuelFor1km;


        public Car(string rengg, string modell, int probegg, double bakinmiqdari, double indikibenzin, double Birkmbenzin) : base(rengg, modell, probegg)
        {
            FuelCapacity = bakinmiqdari;
            CurrentFuel = indikibenzin;
            FuelFor1km = Birkmbenzin;
        }

        public override void Drive(int distance)
        {
            double howlongitwilldrive = CurrentFuel / FuelFor1km;

            if (distance <= howlongitwilldrive)
            {
                Console.WriteLine("You will be able to get the point");

                double artangprobeg = this.Milage + distance;
                double qaligbenzint = CurrentFuel - (distance * FuelFor1km);

                Console.WriteLine($" Now you millage will be {artangprobeg} and you rest oil will be {qaligbenzint}");

            }
            else
            {
                Console.WriteLine("You dont have enough oil");
            }
        }
    }

}
