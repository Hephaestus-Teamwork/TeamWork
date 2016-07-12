using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamWork.Constants;

namespace TeamWork.InfoAndInitialisation
{
    public static class MenuForTheGame
    {
        public static string PressingKey()
        {
            Console.SetCursorPosition(12, 10);
            Console.WriteLine(MenuConstants.chooseOption);
            Console.SetCursorPosition(12, 11);
            Console.WriteLine(MenuConstants.newGame);
            Console.SetCursorPosition(12, 12);
            Console.WriteLine(MenuConstants.highscore);
            Console.SetCursorPosition(12, 13);
            Console.WriteLine(MenuConstants.exitTheGame);

            var pressedKey = Console.ReadKey();
            switch (pressedKey.Key)
            {
                case ConsoleKey.Enter:
                    return "Start";
                case ConsoleKey.H:
                    return "High";
                case ConsoleKey.Escape:
                    return "Exit";
                default: throw new ArgumentException("You entered invalid key!");
            }
        }
    }
}
