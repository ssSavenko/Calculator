namespace Calculator
{
    internal interface ICalculateCommand
    {
        int Calculate(int value1, int value2, char commandCharacter);
    }
}