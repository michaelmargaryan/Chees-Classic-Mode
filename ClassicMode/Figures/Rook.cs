namespace ClassicMode.Figures;

internal class Rook
{
    public bool RookMove(string firstCordinate, string secondCordinate)
    {
        FiguresMove figure = new FiguresMove();
        int iDif = figure.MoveI(firstCordinate, secondCordinate);
        int jDif = figure.MoveJ(firstCordinate, secondCordinate);
        return iDif == 0 || jDif == 0;

    }
}
