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
            Console.WriteLine(MenuConstants.chooseOption);
            Console.WriteLine(MenuConstants.newGame);
            Console.WriteLine(MenuConstants.highscore);
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
