namespace Calculator.CalculateCommand
{
    class CalculateMinusCommand : ICalculateCommand
    {
        public int Calculate(int value1, int value2, char commandCharacter)
        {
            int result = 0;
            if (commandCharacter == '-')
            {
                result = value1 - value2;
            }
            return result;
        }
    }
}