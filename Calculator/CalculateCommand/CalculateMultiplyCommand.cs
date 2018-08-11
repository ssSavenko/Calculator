using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.CalculateCommand
{
    class CalculateMultiplyCommand : ICalculateCommand
    {
        public int Calculate(int value1, int value2, char commandCharacter)
        {
            int result = 0;
            if (commandCharacter == '*')
            {
                result = value1 * value2;
            }
            return result;
        }
    }
}