using System;
using System.Collections.Generic;
using System.IO;
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

        public static bool Questions()
        {
            int vidpov = 0;

            Console.Clear();
            try
            {
                string s = "D:/Study/_TELERIK/TeamWork/Questions H .txt";
                StreamReader sr = new StreamReader(@s, Encoding.Default);
                int count = File.ReadAllLines(@s).Length / 2;
                Console.WriteLine("---Explain the rules---");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                string line;
                int kst_varantiv = 0;
                int choice = 0;
                double kst_pitan = 0;
                int ntrue = 0;//number of true answer
                for (int i = 1; i < count;)
                {
                    line = sr.ReadLine();
                    if (line != null && line.Length == 3)
                    {
                        kst_pitan++;
                        kst_varantiv = int.Parse(line[0].ToString());
                        ntrue = int.Parse(line[2].ToString());
                        for (int l = 1; l <= kst_varantiv; l++)
                        {
                            Console.WriteLine(sr.ReadLine());
                            if (l == kst_varantiv)
                            {
                                choice = Convert.ToInt32(Console.ReadLine());
                                if (choice > kst_varantiv && choice < 1)
                                {
                                    while (choice > kst_varantiv && choice < 1)
                                    {
                                        Console.WriteLine("Error. Enter number from 1 to {0}", kst_varantiv);
                                        choice = Convert.ToInt32(Console.ReadLine());
                                    }
                                }
                                if (choice == ntrue)
                                {
                                    vidpov++;
                                    i++;
                                }
                            }
                        }
                        continue;
                    }
                    else//enter question
                    {
                        //Console.Clear();
                        Console.WriteLine(line);

                        i++;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }

            if (vidpov > 1)
            {
                Console.WriteLine("You pass !");
                Console.ReadKey();
                return true;
            }

            Console.WriteLine("You failed !");
            Console.ReadKey();
            return false;
        }
    }
}
