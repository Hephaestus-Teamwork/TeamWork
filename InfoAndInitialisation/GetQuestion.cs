using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TeamWork.InfoAndInitialisation
{
    public static class GetQuestion
    {
        static List<string> Phisics = new List<string>() { "Light year is a unit of ? ", " 1.time", " 2.distance", " 3.light", " 4.intensity of light" };

        static List<string> Movies = new List<string>() { "Which actor plays Marty McFly in the 'Back to The Future' series of movies ? ",
                                                            "1.Stephen Spielberg","2.Anthony Hopkins", "3.Jack Nicholson","4.Michael J Fox"};

        static List<string> History = new List<string>() { "From which people Bulgaria has derived its name ? ", " 1.Bulgars", " 2.Goths", " 3.Huns", "4.Vandals" };

        static List<string> Literature = new List<string>() { "What word, extended from a more popular term, refers to a fictional book of between 20,000 and 50,000 words ?",
                                                                          " 1. Roman", " 2. Story", " 3. Novella", " 4. News" };

        static List<string> Geometry = new List<string>() { "A circle has a total of how many degrees ?", " 1. 90", " 2. 180", " 3. 360", "4. 540" };

        static List<string> Geography = new List<string>() { "Which of the following is tropical grassland?", " 1.  Taiga", " 2.  Savannah", " 3.  Pampas", " 4.  Prairies" };

        static List<string> Seince = new List<string>() { "Light from the Sun reaches us in nearly", " 1. 2 minutes", " 2. 4 minutes", " 3. 8 minutes", "4. 16 minutes" };

        static List<string> Sport = new List<string>() { "Track and field star Carl Lewis won how many gold medals at the 1984 Olympic games?",
                                                          "1. Two","2. Three","3. Four", "4. Eight" };


        public static bool ChooseQuestionByLetter(string letter)
        {
            string answer = "";

            switch (letter)
            {
                case "P":
                    Console.Write("Quesion : ");
                    Console.WriteLine(Phisics[0]);
                    Console.WriteLine(Phisics[1]);
                    Console.WriteLine(Phisics[2]);
                    Console.WriteLine(Phisics[3]);
                    Console.WriteLine(Phisics[4]);
                    answer = Console.ReadLine();

                    if (answer == "3")
                    {
                        InitialisationOfTheGame.livesCount += 2;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "H":
                    Console.Write("Quesion : ");
                    Console.WriteLine(History[0]);
                    Console.WriteLine(History[1]);
                    Console.WriteLine(History[2]);
                    Console.WriteLine(History[3]);
                    Console.WriteLine(History[4]);
                    answer = Console.ReadLine();

                    if (answer == "1")
                    {
                        InitialisationOfTheGame.livesCount += 2;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "M":
                    Console.Write("Quesion : ");
                    Console.WriteLine(Movies[0]);
                    Console.WriteLine(Movies[1]);
                    Console.WriteLine(Movies[2]);
                    Console.WriteLine(Movies[3]);
                    Console.WriteLine(Movies[4]);
                    answer = Console.ReadLine();

                    if (answer == "1")
                    {
                        InitialisationOfTheGame.livesCount += 2;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "L":
                    Console.Write("Quesion : ");
                    Console.WriteLine(Literature[0]);
                    Console.WriteLine(Literature[1]);
                    Console.WriteLine(Literature[2]);
                    Console.WriteLine(Literature[3]);
                    Console.WriteLine(Literature[4]);
                    answer = Console.ReadLine();

                    if (answer == "2")
                    {
                        InitialisationOfTheGame.livesCount += 2;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "g":
                    Console.Write("Quesion : ");
                    Console.WriteLine(Geometry[0]);
                    Console.WriteLine(Geometry[1]);
                    Console.WriteLine(Geometry[2]);
                    Console.WriteLine(Geometry[3]);
                    Console.WriteLine(Geometry[4]);

                    answer = Console.ReadLine();

                    if (answer == "3")
                    {
                        InitialisationOfTheGame.livesCount += 2;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "G":
                    Console.Write("Quesion : ");
                    Console.WriteLine(Geometry[0]);
                    Console.WriteLine(Geometry[1]);
                    Console.WriteLine(Geometry[2]);
                    Console.WriteLine(Geometry[3]);
                    Console.WriteLine(Geometry[4]);

                    answer = Console.ReadLine();

                    if (answer == "1")
                    {
                        InitialisationOfTheGame.livesCount += 2;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "S":
                    Console.Write("Quesion : ");
                    Console.WriteLine(Seince[0]);
                    Console.WriteLine(Seince[1]);
                    Console.WriteLine(Seince[2]);
                    Console.WriteLine(Seince[3]);
                    Console.WriteLine(Seince[4]);

                    answer = Console.ReadLine();

                    if (answer == "4")
                    {
                        InitialisationOfTheGame.livesCount += 2;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "s":
                    Console.Write("Quesion : ");
                    Console.WriteLine(Sport[0]);
                    Console.WriteLine(Sport[1]);
                    Console.WriteLine(Sport[2]);
                    Console.WriteLine(Sport[3]);
                    Console.WriteLine(Sport[4]);

                    answer = Console.ReadLine();

                    if (answer == "4")
                    {
                        InitialisationOfTheGame.livesCount += 2;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;

            }
        }

    }
}