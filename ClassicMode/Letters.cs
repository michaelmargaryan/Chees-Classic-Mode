﻿namespace ClassicMode
{
    internal class Letters
    {
        public void AddLetterCord()
        {
            Console.Write("");
            for (char num = 'A'; num <= 'H'; num++)
            {
                Console.Write(" " + num + "");
            }
            Console.WriteLine();
        }
    }
}
