using System;
using System.Collections.Generic;
using TeamWork.InfoAndInitialisation;

namespace TeamWork
{
    public class StartTheGame
    {
        static void Main()
        {
            string pressedInitialKey = MenuForTheGame.PressingKey();
            if (pressedInitialKey == "Start")
            {
                MainLogicOfTheGame.MainLogic();
            }
            else if (pressedInitialKey == "High")
            {

            }
            else if (pressedInitialKey == "Exit")
            {
                return;
            }
        }
    }
}