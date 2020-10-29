using System;

namespace Datatypes_And_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 5;

            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;

            double sum2 = d1 + d2;
            double divDandI = d1 / num2;

            string myName = "Claude";

            Console.WriteLine(num1);
            Console.WriteLine($"My name is {myName}".ToLower());
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
            Console.WriteLine($"The sum of {d1} and {d2} is {sum2}");
            Console.WriteLine($"{d1} divided by {num2} equals {divDandI}");
            Console.ReadLine();
        }
    }
}
