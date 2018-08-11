using Calculator.CalculateCommand;
using System;
using System.Windows.Forms;

namespace Calculator
{
    internal partial class CalculatorForm : Form
    {
        private char characterOfOperation = ' ';
        private CalculateCommands commandsForCalculation;
        private string pastText = "";
        private int value1;

        public CalculatorForm()
        {
            InitializeComponent();
            commandsForCalculation = new CalculateCommands();
        }

        private void ButtonValueClicked(string buttonValue)
        {
            if (textBoxForCalculation.Text == "0")
            {
                textBoxForCalculation.Text = buttonValue;
            }
            else
            {
                textBoxForCalculation.Text += buttonValue;
            }
        }

        private void ButtonWith0Value_Click(object sender, EventArgs e)
        {
            ButtonValueClicked("0");
        }

        private void ButtonWith1Value_Click(object sender, EventArgs e)
        {
            ButtonValueClicked("1");
        }

        private void ButtonWith2Value_Click(object sender, EventArgs e)
        {
            ButtonValueClicked("2");
        }

        private void ButtonWith3Value_Click(object sender, EventArgs e)
        {
            ButtonValueClicked("3");
        }

        private void ButtonWith4Value_Click(object sender, EventArgs e)
        {
            ButtonValueClicked("4");
        }

        private void ButtonWith5Value_Click(object sender, EventArgs e)
        {
            ButtonValueClicked("5");
        }

        private void ButtonWith6Value_Click(object sender, EventArgs e)
        {
            ButtonValueClicked("6");
        }

        private void ButtonWith7Value_Click(object sender, EventArgs e)
        {
            ButtonValueClicked("7");
        }

        private void ButtonWith8Value_Click(object sender, EventArgs e)
        {
            ButtonValueClicked("8");
        }

        private void ButtonWith9Value_Click(object sender, EventArgs e)
        {
            ButtonValueClicked("9");
        }
        
        private void CalculateTextBox_TextChanged(object sender, EventArgs e)
        {
            int integerOfTextBox;
            if (!int.TryParse(textBoxForCalculation.Text, out integerOfTextBox) && textBoxForCalculation.Text.Length != 0)
            {
                textBoxForCalculation.Text = pastText;
            }
            else
            {
                pastText = textBoxForCalculation.Text;
            }

            if (firstPartOfCalculation.Text.Length != 0 && textBoxForCalculation.Text.Length != 0)
            {
                equalButton.Enabled = true;
            }
            else
            {
                equalButton.Enabled = false;
            }

            if (textBoxForCalculation.Text.Length > 0 && firstPartOfCalculation.Text.Length == 0)
            {
                divideButton.Enabled = true;
                multiplyButton.Enabled = true;
                minusButton.Enabled = true;
                plusButton.Enabled = true;
            }
            else
            {
                divideButton.Enabled = false;
                multiplyButton.Enabled = false;
                minusButton.Enabled = false;
                plusButton.Enabled = false;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (textBoxForCalculation.Text == "")
            {
                firstPartOfCalculation.Text = "";
            }
            else
            {
                pastText = "";
                textBoxForCalculation.Text = "";
            }
        }

        private void OpereationButtonClicked(char operation)
        {
            value1 = int.Parse(textBoxForCalculation.Text);
            characterOfOperation = operation;
            firstPartOfCalculation.Text = textBoxForCalculation.Text + ' ' + characterOfOperation;
            pastText = "";
            textBoxForCalculation.Text = "";
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            OpereationButtonClicked('/');
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            string newText = commandsForCalculation.PeformCommands(value1, int.Parse(textBoxForCalculation.Text), characterOfOperation).ToString();
            firstPartOfCalculation.Text = "";
            pastText = "";
            textBoxForCalculation.Text = newText;
            equalButton.Enabled = false;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            OpereationButtonClicked('-');
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            OpereationButtonClicked('*');
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            OpereationButtonClicked('+');
        }
    }
}