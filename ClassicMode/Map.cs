﻿namespace ClassicMode
{
    public class Map
    {
        Letters let = new Letters();

        public void NewPrintMap(string[,] board)
        {
            let.AddLetterCord();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {

                    if ((i + j) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    Console.Write(" " + board[i, j]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (j == 7)
                    {
                        Console.Write("| " + Convert.ToString(i + 1));
                    }
                }
                Console.WriteLine();
            }
        }

        public void PrintMap(string[,] board)
        {
            let.AddLetterCord();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = " ";
                    if ((i + j) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    Console.Write(" " + board[i, j]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (j == 7)
                    {
                        Console.Write("| " + Convert.ToString(i + 1));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

