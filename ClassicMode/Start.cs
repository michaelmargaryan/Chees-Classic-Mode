namespace ClassicMode;

internal class Start
{
    public void Classicgame()
    {
        string[,] map = new string[8, 8];
        Map board = new Map();
        board.PrintMap(map);
        ClassicGame game = new ClassicGame();
        game.StartGame(map);
    }
}
