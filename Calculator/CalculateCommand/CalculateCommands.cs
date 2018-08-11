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
            int solutionOfExample = 0;
            for (int i = 0; i < commands.Length; i++)
            {
                solutionOfExample = commands[i].Calculate(value1, value2, commandCharacter);
                if (solutionOfExample != 0)
                {
                    break;
                }
            }
            return solutionOfExample;
        }
    }
}