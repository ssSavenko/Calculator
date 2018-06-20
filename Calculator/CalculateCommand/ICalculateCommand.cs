using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface ICalculateCommand
    {
        int Calculate(int value1, int value2, char commandCharacter);
    }
}
