using System;

namespace MethodWithReturnValueAndParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(1, 2));
            Console.ReadLine();
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
