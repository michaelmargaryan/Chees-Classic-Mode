namespace ClassicMode.Figures;

internal class King
{
    public bool KingMove(string firstCordinate, string secondcordinate)
    {
        FiguresMove figuresMove = new FiguresMove();
        int iDif = figuresMove.MoveI(firstCordinate, secondcordinate);
        int jDif = figuresMove.MoveJ(firstCordinate, secondcordinate);
        return iDif == 0 && jDif == 0 || jDif == 1 && iDif == 0 || jDif == 0 && iDif == 1;
    }
}
