using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter A Number:> ");
            string userInput = Console.ReadLine();
            int num1 = 2;
            int num2 = 0;
            int result;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cant divide by zero");
            }

            try
            {
                
                int userInputInt = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("FormatException, please enter integers only.");
            }
            catch (Exception)
            {
                Console.WriteLine("General exception");
            }
            finally
            {
                Console.WriteLine("This is called any ways.");
            }

            
            Console.ReadLine();
        }
    }
}
