using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose please the figure and you will get ssque and perimetr of it: \n1.Square \n2.Rectangle \n3.Triangle \n4.Circle");

            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Square square = new Square();
                    Console.WriteLine("Please provide the width of square's side:");
                    square.oneside = Convert.ToInt32(Console.ReadLine());
                    square.CalculatePerimeter();
                    square.CalculateArea();
                    break;

                case 2:
                    Rectangle rectangle = new Rectangle();
                    Console.WriteLine("Please provide the height of Rectangle");
                    rectangle.height = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please provide the width of Rectangle");
                    rectangle.width = Convert.ToInt32(Console.ReadLine());
                    rectangle.CalculateArea();
                    rectangle.CalculatePerimeter();
                    break;

                case 3:
                    Triangle x  = new Triangle();
                    Console.WriteLine("Please provide the width of triangle's side:");
                    x.oneside = Convert.ToInt32(Console.ReadLine());
                    x.CalculatePerimeter();
                    x.CalculateArea();
                    break;

                case 4:
                    circle circle= new circle();
                    Console.WriteLine("Please provide the R-adius of circle: ");
                    circle.rad=Convert.ToInt32(Console.ReadLine());
                    circle.CalculatePerimeter();
                    circle.CalculateArea();
                    break;



            }








        }
    }
    interface Ifigure
    {
        void CalculateArea();
        void CalculatePerimeter();
    }

    public class Square : Ifigure
    {
        public int oneside;
        public void CalculateArea()
        {
            int area = oneside * oneside;
            Console.WriteLine("Area will be " + area);
        }

        public void CalculatePerimeter()
        {
            int perimeter = (oneside + oneside) * 2;
            Console.WriteLine("Perimetr wil be " + perimeter);
        }
    }

    public class Rectangle : Ifigure
    {
        public int width;
        public int height;
        public void CalculateArea()
        {
            int area = width * height;
            Console.WriteLine("Area will be " + area);
        }

        public void CalculatePerimeter()
        {
            int per = 2 * (width + height);
            Console.WriteLine("Perimetr wil be " + per);
        }
    }

    public class Triangle : Ifigure
    {
        public int oneside;
        public void CalculateArea()
        {
            double area = 1.73 * oneside * oneside / 4;
            Console.WriteLine("Area will be " + area);
        }

        public void CalculatePerimeter()
        {
            int per = oneside * 3;
            Console.WriteLine("Perimetr wil be " + per);
        }
    }

    public class circle: Ifigure
    {
        public int rad;
        double pit = 3.14;

        public void CalculateArea()
        {
            double area = rad * pit * rad;
            Console.WriteLine("Area will be " + area);
        }

        public void CalculatePerimeter()
        {
            double per=2* pit * rad;
            Console.WriteLine("Perimetr wil be " + per);
        }
    }


}
