namespace ClassicMode.Figures;

internal class Queen
{
    public bool QueenMove(string firstCordinate, string secondCordinate)
    {
        FiguresMove move = new FiguresMove();
        int iDif = move.MoveI(firstCordinate, secondCordinate);
        int jDif = move.MoveJ(firstCordinate, secondCordinate);
        return iDif == 0 || jDif == 0 || iDif == jDif;
    }
}
