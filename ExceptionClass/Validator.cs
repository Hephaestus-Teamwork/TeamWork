using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWork.ExceptionClass
{
    public static class Validator
    {
        public static void CheckIfNull(object obj, string message = null)
        {
            if (obj==null)
            {
                throw new NullReferenceException(message);
            }
        }

        public static bool CheckIfCorrectAnswerFormat(string aswer)
        {
            if (string.IsNullOrEmpty(aswer))
            {
                return false;
            }
            if (int.Parse(aswer) == 1 || int.Parse(aswer) == 2 || int.Parse(aswer) == 3 || int.Parse(aswer) == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
