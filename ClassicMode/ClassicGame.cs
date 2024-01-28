using ClassicMode.Figures;
using static System.Console;

namespace ClassicMode
{
    internal class ClassicGame
    {
        Bishop Bishop = new Bishop();
        King King = new King();
        Knight Knight = new Knight();
        Rook Rook = new Rook();
        Queen Queen = new Queen();
        Addfigures Addfigures = new Addfigures();


        public void StartGame(string[,] map)
        {

            OutputEncoding = System.Text.Encoding.UTF8;
            WriteLine("Enter Figure: k-King , Q - Queen , R -Rook , B -Bishop , H - Knight");
            ConsoleKeyInfo pressedKey = Console.ReadKey();
            Console.Write("Enter the first Coordinat: ");
            string firstCoord = Console.ReadLine().ToUpper();
            Console.Write("Enter the second Coordinat: ");
            string secondCoord = Console.ReadLine().ToUpper();
            bool userInput = false;
            char figure;
            switch (pressedKey.Key)
            {
                case ConsoleKey.K:
                    userInput = King.KingMove(firstCoord, secondCoord);
                    figure = '\u265A';
                    Valid(userInput, figure, map, firstCoord, secondCoord);
                    break;
                case ConsoleKey.R:
                    userInput = Rook.RookMove(firstCoord, secondCoord);
                    figure = '\u265C';
                    Valid(userInput, figure, map, firstCoord, secondCoord);
                    break;
                case ConsoleKey.H:
                    userInput = Knight.KnightMove(firstCoord, secondCoord);
                    figure = '\u265E';
                    Valid(userInput, figure, map, firstCoord, secondCoord);
                    break;
                case ConsoleKey.Q:
                    userInput = Queen.QueenMove(firstCoord, secondCoord);
                    figure = '\u265B';
                    Valid(userInput, figure, map, firstCoord, secondCoord);
                    break;
                case ConsoleKey.B:
                    userInput = Bishop.BishopMove(firstCoord, secondCoord);
                    figure = '\u265D';
                    Valid(userInput, figure, map, firstCoord, secondCoord);
                    break;
                default:
                    WriteLine("invalid input");
                    break;
            }


        }
        static void Valid(bool userInput, char figure, string[,] map, string firstCoord, string secondCoord)
        {
            Map map1 = new Map();
            Addfigures addfigures = new Addfigures();
            if (userInput)
            {
                WriteLine($"Valid move!");
                addfigures.AddFigureToMap(map, firstCoord, figure);
                addfigures.AddFigureToMap(map, secondCoord, figure);
                map1.NewPrintMap(map);
            }
            else
            {
                WriteLine("Invalid input");
            }

        }
    }
}
