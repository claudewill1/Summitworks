using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // have user enter a message they want to keep secret and save to secret
            Console.Write("Please enter a message you would like to keep secret: ");
            string secret = Console.ReadLine().ToLower();
            // convert secret to an array of characters
            char[] secretMessage = secret.ToCharArray();
            // create empty char array to hold the length of the message in characters
            char[] encryptedMessage = new char[secretMessage.Length];
            string encrypted = Encrypt(secretMessage, 3);
            string decrypted = Decrypt(encrypted, 3);

            Console.WriteLine($"Here is the encrypted message: {encrypted}");
            Console.WriteLine($"Here is the decrypted message: {decrypted}");


            Console.ReadLine();


        }
        private static string Encrypt(char[] message, int num)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] encryptedMessage = new char[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                char letter = message[i];
                int index = Array.IndexOf(alphabet, letter);
                int letterPos = (index += 3) % 26;
                char encryptLetter = alphabet[letterPos];
                encryptedMessage[i] = encryptLetter;
            }
            string encryptedMsg = String.Join("", encryptedMessage);
            return encryptedMsg;
        }
        private static string Decrypt(string message, int num)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
                'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] decryptedMsg = new char[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                char letter = message[i];
                int index = Array.IndexOf(alphabet, letter);
                int letterPos = (index -= 3) % 26;
                char decryptedLetter = alphabet[letterPos];
                decryptedMsg[i] = decryptedLetter;
            }
            string decryptMsg = String.Join("", decryptedMsg);
            return decryptMsg;
        }
    }
}
