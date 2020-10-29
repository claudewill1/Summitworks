using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[,] newBoard = new string[CreateBoard().Length];
            CreateBoard();
            Console.ReadLine();
        }
        static void CreateBoard()
        {
            string[,] board = new string[,] { {"-","|","-","|","-"},
                               {"-","|","-","|","-"},
                               {"-","|","-","|","-"} };

            Console.WriteLine($"{board[0,0]}{board[0,1]}{board[0,2]}{board[0,3]}{board[0,4]}\n" +
                              $"{board[1,0]}{board[1,1]}{board[1,2]}{board[1,3]}{board[1,4]}\n" +
                              $"{board[2,0]}{board[2,1]}{board[2,2]}{board[2,3]}{board[2,4]}");
        }
        static string[] AddToken(int xCoord, int yCoord, string token)
        {
            
        }
        
    }
}
