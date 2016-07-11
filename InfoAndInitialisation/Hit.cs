using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TeamWork.InfoAndInitialisation
{
    public abstract class Hit
    {
        public static string hitLetter;

        public static void FlashScreen()
        {
            Console.Beep();
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Thread.Sleep(100);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Thread.Sleep(100);
                Console.Clear();
            }
        }

        public static bool Questions(Letters letter)
        {
            bool isAnswerCorrect = false;
            Random rand = new Random();
            int randomNumber = rand.Next(0, 5);

            Console.Clear();
            try
            {
                string s = "D:/Study/_TELERIK/TeamWork/Questions/"; // + letter + randomNumber;
                StreamReader sr = new StreamReader(@s, Encoding.Default);
                int count = File.ReadAllLines(@s).Length / 2;
                Console.WriteLine("---Explain the rules---");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                //Print hole file on the screeen

              //  TODO add letter in main program constructor
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
                hitLetter = letter.RandomEnumeration.ToString();
            }

            if (isAnswerCorrect)
            {
                Console.WriteLine("You pass !");
                Console.ReadKey();
                return true;
            }
            else
            {
                Console.WriteLine("You failed !");
                GetQuestion.ChooseQuestionByLetter(hitLetter);
                Console.ReadKey();
                return false;
            }
        }
    }
}
