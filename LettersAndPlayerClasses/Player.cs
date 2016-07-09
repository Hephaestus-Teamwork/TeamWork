using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWork
{
    public class Player
    {
        private static Player instance = null;
        private string body;
        private int x; // position of '('

        private Player()
        {
            body = "\\" + ((char)2).ToString() + "/";
            x = InitialisationOfTheGame.playGroundWidth / 2 - 1;
            Print();
        }

        public static Player GetInstance()
        {
            if (instance == null)
            {
                instance = new Player();
            }
            return instance;
        }

        public void MoveLeft()
        {
            if (x > 0)
            {
                x--;
            }
        }

        public void MoveRight()
        {
            if (x < InitialisationOfTheGame.playGroundWidth - 2)
            {
                x++;
            }
        }

        public void Print(bool hit = false)
        {
            Console.SetCursorPosition(x, Console.WindowHeight - 1);
            Console.ForegroundColor = hit ? ConsoleColor.Red : ConsoleColor.Yellow;
            Console.Write(hit ? "XXX" : body);
        }

        public bool Overlap(Letters r)
        {
            if (Console.WindowHeight - 1 == r.Y)
            {
                if (x == r.X || x + 1 == r.X || x + 2 == r.X)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
