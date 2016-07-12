using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWork.InfoAndInitialisation
{
    public static class HighScore
    {
        public static void HighestScore(long currentScore)
        {
            long finalScore = 0;
            if (finalScore < currentScore)
            {
                finalScore = currentScore;
            }
            Console.WriteLine();
            Console.WriteLine("The highest score is: {0}", finalScore);
        }
    }
}
