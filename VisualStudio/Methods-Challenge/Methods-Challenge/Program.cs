using System;

namespace Methods_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "bob";
            string name2 = "tom";
            string name3 = "Alex";
            Console.WriteLine($"{GreetFriend(name1)}\n{GreetFriend(name2)}\n{GreetFriend(name3)}");
            Console.ReadLine();
        }
        static string GreetFriend(string friend)
        {
            return $"Hello {friend}, my friend!";
        }
    }
}
