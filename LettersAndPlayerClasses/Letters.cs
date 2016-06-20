using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWork
{
    public class Letters
    {
        public static int playGroundWidth = 30;
        private int x;
        private int y;
        private ConsoleColor colour;
        private EnumerationOfCharacters randomEnumeration;
        private static Random rand = new Random();

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public ConsoleColor Colour
        {
            get { return this.colour; }
            set { this.colour = value; }
        }

        public EnumerationOfCharacters RandomEnumeration
        {
            get { return this.randomEnumeration; }
            set { this.randomEnumeration = value; }
        }

        private ConsoleColor GetRandomConsoleColor()
        {
            int r = rand.Next(16);
            switch (r)
            {
                case 0: return ConsoleColor.White;
                case 1: return ConsoleColor.Blue;
                case 2: return ConsoleColor.Cyan;
                case 3: return ConsoleColor.DarkBlue;
                case 4: return ConsoleColor.DarkCyan;
                case 5: return ConsoleColor.DarkGray;
                case 6: return ConsoleColor.White;
                case 7: return ConsoleColor.DarkGreen;
                case 8: return ConsoleColor.DarkMagenta;
                case 9: return ConsoleColor.DarkRed;
                case 10: return ConsoleColor.DarkYellow;
                case 11: return ConsoleColor.Gray;
                case 12: return ConsoleColor.Green;
                case 13: return ConsoleColor.Magenta;
                case 14: return ConsoleColor.Red;
                case 15: return ConsoleColor.Yellow;
                default: return ConsoleColor.Black;
            }
        }
        public Letters()
        {
            Array values = Enum.GetValues(typeof(EnumerationOfCharacters));
            randomEnumeration = (EnumerationOfCharacters)values.GetValue(rand.Next(values.Length));
            X = rand.Next(playGroundWidth);
            Y = 0;
            Colour = GetRandomConsoleColor();
        }
        public bool MoveDown()
        {
            if (Y < Console.WindowHeight - 1)
            {
                Y++;
                return true;
            }
            return false;
        }
        public void Print()
        {
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = colour;
            Console.Write(randomEnumeration);
        }
    }
}
