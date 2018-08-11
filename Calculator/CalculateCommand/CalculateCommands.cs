namespace Calculator.CalculateCommand
{
    internal class CalculateCommands
    {
        private ICalculateCommand[] commands;

        public CalculateCommands()
        {
            commands = new ICalculateCommand[]
            {
                new CalculateDivideCommand(),
                new CalculateMinusCommand(),
                new CalculateMultiplyCommand(),
                new CalculatePlusCommand()
            };
        }

        public int PeformCommands(int value1, int value2, char commandCharacter)
        {
            int returnValue = 0;
            for(int i =0; i< commands.Length;i++)
            {
                returnValue = commands[i].Calculate(value1, value2, commandCharacter);
                if (returnValue != 0)
                {
                    break;
                }
            }
            return returnValue;
        }
    }
}