namespace ClassicMode.Figures;

internal class Bishop
{
    public bool BishopMove(string firstCordinate, string secondCordinate)
    {
        FiguresMove figuresMove = new FiguresMove();
        int iDif = figuresMove.MoveI(firstCordinate, secondCordinate);
        int jDif = figuresMove.MoveJ(firstCordinate, secondCordinate);
        return iDif == jDif;
    }
}
