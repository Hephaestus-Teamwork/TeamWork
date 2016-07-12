using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TeamWork.ExceptionClass;

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
            Random rand = new Random();
            int number = rand.Next(1, 4);
            string pressedKey;

            Console.Clear();

            string s = @"D:\Study\_TELERIK\TeamWork\TeamWork-master\TeamWork-master\TeamWork\Questions\" + letter.RandomEnumeration.ToString().ToUpper() + "\\" + number + ".txt";
            StreamReader sr = new StreamReader(@s, Encoding.Default);
            var text = File.ReadAllLines(@s);

            foreach (var line in text)
            {
                Console.WriteLine(line);
            }

            do
            {
                Console.Write("Enter your answer: ");
                pressedKey = Console.ReadLine();
            } while (!Validator.CheckIfCorrectAnswerFormat(pressedKey));


            if (int.Parse(pressedKey) == number)
            {
                Console.WriteLine("You pass !");
                Console.ReadKey();
                return true;
            }
            else
            {
                Console.WriteLine("You failed !");
                Console.WriteLine("Correct answer is " + number + " !");
                GetQuestion.ChooseQuestionByLetter(hitLetter);
                Console.ReadKey();
                return false;
            }
        }
    }
}
