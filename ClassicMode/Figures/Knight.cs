namespace ClassicMode.Figures
{
    internal class Knight
    {
        public bool KnightMove(string firstCordinate, string secondCordinate)
        {
            FiguresMove move = new FiguresMove();

            int iDif = move.MoveI(firstCordinate, secondCordinate);
            int jDif = move.MoveJ(firstCordinate, secondCordinate);
            return (iDif == 2 && jDif == 1) || (iDif == 1 && jDif == 2);
        }
    }
}
