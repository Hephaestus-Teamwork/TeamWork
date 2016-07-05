using System;
using System.Collections.Generic;
using System.Threading;

namespace TeamWork
{
    public class Game
    {     
        static Random rand = new Random();
        static List<Letters> letters;
        
        static void Main()
        {
            InitialisationOfTheGame.Initialisation();
            letters = new List<Letters>();
            Player player = Player.GetInstance();
            List<Letters> removeObsoletes;
            bool hit = false;
            ConsoleKeyInfo pressedKey;
            while (true)
            {
                // adding new letters
                for (int i = 0, count = rand.Next(InitialisationOfTheGame.playGroundWidth / (InitialisationOfTheGame.scores > 100 ? 7 : 10)); i < count; i++)
                {
                    letters.Add(new Letters());
                }
                // moving our player
                while (Console.KeyAvailable)
                {
                    pressedKey = Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow || pressedKey.Key == ConsoleKey.A) // <--
                    {
                        player.MoveLeft();
                    }
                    if (pressedKey.Key == ConsoleKey.RightArrow || pressedKey.Key == ConsoleKey.D) // -->
                    {
                        player.MoveRight();
                    }
                    if (pressedKey.Key == ConsoleKey.Escape) // Esc
                    {
                        Environment.Exit(0); // leave game
                    }
                }
                removeObsoletes = new List<Letters>(); // letters, which are to leave the screen
                hit = false;
                foreach (Letters letter in letters)
                {
                    if (!letter.MoveDown())
                    {
                        removeObsoletes.Add(letter);
                    }
                    if (player.Overlap(letter)) // if hit
                    {
                        InitialisationOfTheGame.livesCount--;
                        hit = true;

                        {  //TODO: move this somewhere
                            Console.Beep();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Thread.Sleep(100);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Thread.Sleep(100);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Thread.Sleep(100);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Thread.Sleep(100);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Thread.Sleep(100);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Thread.Sleep(100);
                            Console.Clear();
                        }
                        if (InitialisationOfTheGame.livesCount == 0) // game over
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Out.WriteLine("GAME OVER !!!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Environment.Exit(0);
                        }
                    }
                }
                Console.Clear();
                foreach (Letters old in removeObsoletes) // removing letters, which are to leave the screen
                {
                    letters.Remove(old);
                    InitialisationOfTheGame.scores++;
                }
                if (hit)
                {
                    letters.Clear();
                    InitialisationOfTheGame.scores -= 10;
                }
                // printing
                foreach (Letters letter in letters)
                {
                    letter.Print();
                }
                player.Print(hit);
                Info.DisplayInfo();
                InitialisationOfTheGame.Sleep();
            }
        }
    }
}