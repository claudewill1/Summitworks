using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
            Console.ReadLine();
        }
        public static int Calculate()
        {
            Console.Write("Please enter the first number: ");
            string numString1 = Console.ReadLine();
            Console.Write("Please enter the second number: ");
            string numString2 = Console.ReadLine();

            int num1 = int.Parse(numString1);
            int num2 = int.Parse(numString2);

            int result = num1 + num2;

            return result;

        }
    }
}
