using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TeamWork
{
    public static class InitialisationOfTheGame
    {
        public static int playGroundWidth = 30;
        public static long scores;
        public static int livesCount = 3;

        
        public static void Initialisation()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            Console.Title = "Falling Rocks";
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth = 50;
            InitialisationOfTheGame.scores = 0;        
        }

        public static void Sleep()
        {
            Thread.Sleep(200);
        }
    }
}
