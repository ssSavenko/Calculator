using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Calculator.CalculateCommand;
using System.Windows.Forms;

namespace Calculator
{
    internal partial class CalculatorForm : Form
    {
        private char characterOfOperation = ' ';
        private CalculateCommands commandsForCalculation;
        private bool isLastOperationEqual = false;
        private string pastText = "";
        private int value1 = 0;

        public CalculatorForm()
        {
            InitializeComponent();
            commandsForCalculation = new CalculateCommands();
        }

        private void ButtonWith0Value_Click(object sender, EventArgs e)
        {
            if (textBoxForCalculation.Text != "0")
            {
                textBoxForCalculation.Text += "0";
            }
        }

        private void ButtonWith1Value_Click(object sender, EventArgs e)
        {
            if (textBoxForCalculation.Text == "0")
            {
                textBoxForCalculation.Text = "1";
            }
            else
            {
                textBoxForCalculation.Text += "1";
            }
        }

        private void ButtonWith2Value_Click(object sender, EventArgs e)
        {
            if (textBoxForCalculation.Text == "0")
            {
                textBoxForCalculation.Text = "2";
            }
            else
            {
                textBoxForCalculation.Text += "2";
            }
        }

        private void ButtonWith3Value_Click(object sender, EventArgs e)
        {
            if (textBoxForCalculation.Text == "0")
            {
                textBoxForCalculation.Text = "3";
            }
            else
            {
                textBoxForCalculation.Text += "3";
            }
        }

        private void ButtonWith4Value_Click(object sender, EventArgs e)
        {
            if (textBoxForCalculation.Text == "0")
            {
                textBoxForCalculation.Text = "4";
            }
            else
            {
                textBoxForCalculation.Text += "4";
            }
        }

        private void ButtonWith5Value_Click(object sender, EventArgs e)
        {
            if (textBoxForCalculation.Text == "0")
            {
                textBoxForCalculation.Text = "5";
            }
            else
            {
                textBoxForCalculation.Text += "5";
            }
        }

        private void ButtonWith6Value_Click(object sender, EventArgs e)
        {
            if (textBoxForCalculation.Text == "0")
            {
                textBoxForCalculation.Text = "6";
            }
            else
            {
                textBoxForCalculation.Text += "6";
            }
        }

        private void ButtonWith7Value_Click(object sender, EventArgs e)
        {
            if (textBoxForCalculation.Text == "0")
            {
                textBoxForCalculation.Text = "7";
            }
            else
            {
                textBoxForCalculation.Text += "7";
            }
        }

        private void ButtonWith8Value_Click(object sender, EventArgs e)
        {
            if (textBoxForCalculation.Text == "0")
            {
                textBoxForCalculation.Text = "8";
            }
            else
            {
                textBoxForCalculation.Text += "8";
            }
        }

        private void ButtonWith9Value_Click(object sender, EventArgs e)
        {
            if (textBoxForCalculation.Text == "0")
            {
                textBoxForCalculation.Text = "9";
            }
            else
            {
                textBoxForCalculation.Text += "9";
            }
        }
        
        private void CalculateTextBox_TextChanged(object sender, EventArgs e)
        {
            bool newIsLastOperationEqual = false;
            int i;
            if (!int.TryParse(textBoxForCalculation.Text, out i) && textBoxForCalculation.Text.Length != 0)
            {
                newIsLastOperationEqual = true;
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

            if (textBoxForCalculation.Text.Length > 0 && firstPartOfCalculation.Text.Length == 0 && !isLastOperationEqual)
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
            isLastOperationEqual = newIsLastOperationEqual;
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

        private void DivideButton_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBoxForCalculation.Text);
            characterOfOperation = '/';
            firstPartOfCalculation.Text = textBoxForCalculation.Text + ' ' + characterOfOperation;
            pastText = "";
            textBoxForCalculation.Text = "";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            isLastOperationEqual = true;
            string newText = commandsForCalculation.PeformCommands(value1, int.Parse(textBoxForCalculation.Text), characterOfOperation).ToString();
            firstPartOfCalculation.Text = "";
            pastText = "";
            textBoxForCalculation.Text = newText;
            equalButton.Enabled = false;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBoxForCalculation.Text);
            characterOfOperation = '-';
            firstPartOfCalculation.Text = textBoxForCalculation.Text + ' ' + characterOfOperation;
            pastText = "";
            textBoxForCalculation.Text = "";
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBoxForCalculation.Text);
            characterOfOperation = '*';
            firstPartOfCalculation.Text = textBoxForCalculation.Text + ' ' + characterOfOperation;
            pastText = "";
            textBoxForCalculation.Text = "";
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBoxForCalculation.Text);
            characterOfOperation = '+';
            firstPartOfCalculation.Text = textBoxForCalculation.Text + ' ' + characterOfOperation;
            pastText = "";
            textBoxForCalculation.Text = "";
        }
    }
}
