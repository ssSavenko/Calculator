using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.CalculateCommand
{
    class CalculateMinusCommand : ICalculateCommand
    {
        public int Calculate(int value1, int value2, char function)
        {
            int returnValue = 0;
            if (function == '-')
            {
                returnValue = value1 - value2;
            }
            return returnValue;
        }
    }
}
