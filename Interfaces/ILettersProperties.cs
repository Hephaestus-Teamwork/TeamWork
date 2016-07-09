using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWork.Interfaces
{
    public interface ILettersProperties
    {
        int X { get; }
        int Y { get; }
        ConsoleColor Colour { get; }
        EnumerationOfCharacters RandomEnumeration { get; }
    }
}
