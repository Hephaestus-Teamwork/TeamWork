﻿using System;

namespace TeamWork
{
    public class Info
    {
        public static void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(InitialisationOfTheGame.playGroundWidth + 5, 5);
            Console.Out.WriteLine("Lives: {0}", InitialisationOfTheGame.livesCount);

            Console.SetCursorPosition(InitialisationOfTheGame.playGroundWidth + 5, 7);
            Console.Out.WriteLine("Scores: {0}", InitialisationOfTheGame.scores);
        }
    }
}
