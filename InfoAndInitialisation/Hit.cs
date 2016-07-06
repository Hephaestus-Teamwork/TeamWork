using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TeamWork.InfoAndInitialisation
{
    public class Hit
    {
        public static void FlashScreen()
        {
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
    }
}
