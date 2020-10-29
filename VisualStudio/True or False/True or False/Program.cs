using System;

namespace True_or_False
{
    class Program
    {
        static void Main(string[] args)
        {
                   
        // Do not edit these lines
        Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
        string entry = Console.ReadLine();
        Tools.SetUpInputStream(entry);

        // Type your code below
        string[] questions = { "The sky is blue", "The Sun is a planet", "m is is a vowel", "Mars is the third planet from the sun", "Jupiter is the largest planet in our solar system" };
        bool[] answers = { true, false, false, false, true };
        bool[] responses = new bool[questions.Length];
        int askingIndex = 0;
        foreach (string question in questions)
        {
            string input;
            bool isBool;
            bool inputBool;
            Console.WriteLine($"{question}\nTrue or False? ");
            input = Console.ReadLine().ToLower(); ;
            isBool = Boolean.TryParse(input, out inputBool);
            while (!isBool)
            {
                Console.WriteLine("Pleases respond with 'true' or 'false'.");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);
            }

             responses[askingIndex] = inputBool;
             askingIndex++;

         }


        /*Console.WriteLine("The users Input");
        Console.WriteLine("===============");
        for(int i = 0; i < responses.Length; i++){
        Console.WriteLine(responses[i]);*/

        // Calculate score
        int scoreIndex = 0;
        int score = 0;

        foreach (bool answer in answers)
        {
            bool response = responses[scoreIndex];
            Console.WriteLine($"Input: {responses[scoreIndex]} | Answer: {answers[scoreIndex]}");
            if (response == answer)
            {
                score++;
            }
            scoreIndex++;
        }
        Console.WriteLine($"You got {score} out of {answers.Length} correct!");
            
        }

    }

}

