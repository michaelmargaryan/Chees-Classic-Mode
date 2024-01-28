namespace ClassicMode.Figures;

public class FiguresMove
{
    public int MoveI(string firstCordinate, string secondCordinate)
    {
        int i1 = (int)firstCordinate[1];
        int i2 = (int)secondCordinate[1];
        int iDifference = Math.Abs(i1 - i2);
        return iDifference;
    }
    public int MoveJ(string firstCordinate, string secondCordinate)
    {
        char j1 = firstCordinate[0];
        char j2 = secondCordinate[0];
        int jDifference = Math.Abs(j1 - j2);
        return jDifference;
    }
}
