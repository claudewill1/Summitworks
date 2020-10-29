using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            /* use this space to write your own short program! 
            Here's what you learned:

            BOOL TYPE: bool variableName
            COMPARISON OPERATORS: ==, <, >, <=, >=
            LOGICAL OPERATORS: &&, ||, !

            Good luck! */
            
            Console.Write("enter a password: ");
            string password = Console.ReadLine();

            

            int score = 0;
            

            //check password length
            if(password.Length >= 8)
            {
                score++;
                
            } 
            //check if contains uppercase
            if (password.Any(char.IsUpper))
            {
                score++;              
            }
            //check for lowercase
            if (password.Any(char.IsLower))
            {
                score++;     
            }
            //check for special character
            if (password.Any(char.IsLetterOrDigit))
            {
                score++;
            }
            // check for digits
            if (password.Any(char.IsDigit))
            {
                score++;
            }
            if (password == "password" || password == "1234")
            {
                score = 0;
            }
            if (password == null) score = 0;
            Console.WriteLine(score);

            
            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Password is Extremely Strong");
                    break;
                case 3:
                    Console.WriteLine("Password is Strong");
                    break;
                case 2:
                    Console.WriteLine("Password is Medium");
                    break;
                case 1:
                    Console.WriteLine("Password is Weak");
                    break;
                default:
                    Console.WriteLine("Password meets no conditions");
                    break;


            }
           


            Console.ReadLine();

        }
        public static void isPasswordValid(string str)
        {
            //Regex to check if string contains uppercase,
            //lowercase letters, special characters and digits
            string regex = "^ (?=.*[a - z])(?=."
                       + "*[A-Z])(?=.*\\d)"
                       + "(?=.*[-+_!@#$%^&*., ?]).+$"; 
            // start off by checking if there is any input
            if(str == null)
            {
                Console.WriteLine("Invalid password!");
                return;
            }
            Match m = Regex.Match(str, regex);

            while (m.Success)
            {
                Console.WriteLine("Password is valid!");
            }

        }


    }
}