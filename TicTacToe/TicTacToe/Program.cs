using System;

namespace TicTacToe
{
    class Program
    {
		public static char[,] board = new char[3, 3];

        static void Main(string[] args)
        {
            CreateBoard();
            Console.ReadLine();
        }
		public static void CreateBoard()
		{
			for (int i = 0; i < 3; ++i)
			{
				for (int j = 0; j < 3; ++j)
				{
					Console.Write(board[i,j]);
					if (j < 2)
					{
						Console.Write("|");
					}
				}
				Console.Write("\n");
			}
			Console.Write("\n");
		}
	}
}
