using System;

namespace Architect_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateTotalCost();

        }
        static double Rect(double len, double width)
        {
            // declare area variable and assign the value of length * width
            // for parts of the building which are rectangular in shape
            double area = len * width;
            return area;
        }
        static double Circle(double radius)
        {
            // calculate and return area of part of building which is shaped as a circle
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        static double Triangle(double bottom, double height)
        {
            // calculate and return area of triangular shaped areas of buildings
            double area = 0.5 * bottom * height;
            return area;
        }
        static void CalculateTotalCost()
        {
            double totalArea = Rect(2500, 1500) + (Circle(375)/2) + Triangle(750, 500);
            double pesos = 180.00;
            double flooringCost = totalArea * pesos;
            flooringCost = Math.Round(flooringCost, 2);
            Console.WriteLine($"The total cost for flooring for the Teotihuacan in Mexico is " +
                $"{flooringCost} pesos.");
            Console.ReadLine();
        }
    }
}
