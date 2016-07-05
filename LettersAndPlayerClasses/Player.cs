using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamWork.Structure;

namespace TeamWork
{
    public class Player
    {
        private static Player instance = null;
        StructureForPlayer player = new StructureForPlayer("(0)", InitialisationOfTheGame.playGroundWidth / 2 - 1);

        private Player()
        {
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
            if (this.player.X > 0)
            {
                this.player.X--;
            }
        }
        public void MoveRight()
        {
            if (this.player.X < InitialisationOfTheGame.playGroundWidth - 2)
            {
                this.player.X++;
            }
        }
        public void Print(bool hit = false)
        {
            Console.SetCursorPosition(this.player.X, Console.WindowHeight - 1);
            Console.ForegroundColor = hit ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write(hit ? "XXX" : this.player.Body);
        }
        public bool Overlap(Letters r)
        {
            if (Console.WindowHeight - 1 == r.Y)
            {
                if (this.player.X == r.X || this.player.X + 1 == r.X || this.player.X + 2 == r.X)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
