using System;
using System.Collections.Generic;
using TeamWork.InfoAndInitialisation;

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
                        hit = true;

                        if (!Hit.Questions())
                        {
                            InitialisationOfTheGame.livesCount--;
                            Hit.FlashScreen();

                            if (InitialisationOfTheGame.livesCount == 0) // game over 
                            {
                                Console.SetCursorPosition(14, 8);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("GAME OVER!!!");

                                Console.SetCursorPosition(17, 10);
                                Console.Out.WriteLine(((char)3).ToString() + " " + ((char)3).ToString() + " " + ((char)3).ToString()); //Three hearts

                                Console.SetCursorPosition(12, 12);
                                Console.Out.WriteLine("Your score is {0} ", InitialisationOfTheGame.scores); //Result

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                                Environment.Exit(0);
                            }
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