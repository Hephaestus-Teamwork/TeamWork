using System;
using System.Collections.Generic;
using TeamWork.InfoAndInitialisation;

namespace TeamWork
{
    public class StartTheGame
    {
        public static void Main()
        {
            string pressedInitialKey = MenuForTheGame.PressingKey();
            if (pressedInitialKey == "Start")
            {
                MainLogicOfTheGame.MainLogic();
            }
            else if (pressedInitialKey == "High")
            {
                HighScore.HighestScore(InitialisationOfTheGame.scores);
            }
            else if (pressedInitialKey == "Exit")
            {
                return;
            }
        }
    }
}