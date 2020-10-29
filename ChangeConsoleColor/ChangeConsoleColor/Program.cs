using System;

namespace ChangeConsoleColor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Hi");
            Console.ReadLine();
        }
    }
}
