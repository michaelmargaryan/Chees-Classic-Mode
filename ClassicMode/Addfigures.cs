namespace ClassicMode;

public class Addfigures
{
    public void AddFigureToMap(string[,] Board, string coord, char figure1)
    {
        char column = coord[0];
        int row = int.Parse(coord.Substring(1)) - 1;
        string figure = Convert.ToString(figure1);

        Board[row, column - 'A'] = figure;
    }
}
