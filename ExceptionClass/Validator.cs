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
    }
}
