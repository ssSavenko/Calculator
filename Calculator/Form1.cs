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
    internal partial class Form1 : Form
    {
        private string pastText = "";
        private int value1 = 0;
        private char characterOfOperation = ' ';
        private CalculateCommands commandsForCalculation;

        public Form1()
        {
            InitializeComponent();
            commandsForCalculation = new CalculateCommands();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i;
            if((!int.TryParse(textBoxForCalculation.Text, out i) && textBoxForCalculation.Text.Length != 0) || textBoxForCalculation.Text == "0")
            {
                textBoxForCalculation.Text = pastText; 
            }
            else
            {
                pastText = textBoxForCalculation.Text;
            }

            if (firstPartOfCalculation.Text.Length != 0 &&  textBoxForCalculation.Text.Length != 0)
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

        private void clearButton_Click(object sender, EventArgs e)
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

        private void buttonWith1Value_Click(object sender, EventArgs e)
        {
            textBoxForCalculation.Text += "1";
        }

        private void buttonWith2Value_Click(object sender, EventArgs e)
        {
            textBoxForCalculation.Text += "2";
        }

        private void buttonWith3Value_Click(object sender, EventArgs e)
        {
            textBoxForCalculation.Text += "3";
        }

        private void buttonWith4Value_Click(object sender, EventArgs e)
        {
            textBoxForCalculation.Text += "4";
        }

        private void buttonWith5Value_Click(object sender, EventArgs e)
        {
            textBoxForCalculation.Text += "5";
        }

        private void buttonWith6Value_Click(object sender, EventArgs e)
        {
            textBoxForCalculation.Text += "6";
        }

        private void buttonWith7Value_Click(object sender, EventArgs e)
        {
            textBoxForCalculation.Text += "7";
        }

        private void buttonWith8Value_Click(object sender, EventArgs e)
        {
            textBoxForCalculation.Text += "8";
        }

        private void buttonWith9Value_Click(object sender, EventArgs e)
        {
            textBoxForCalculation.Text += "9";
        }

        private void buttonWith0Value_Click(object sender, EventArgs e)
        {
            textBoxForCalculation.Text += "0";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBoxForCalculation.Text);
            characterOfOperation = '+';
            firstPartOfCalculation.Text = textBoxForCalculation.Text + ' ' + characterOfOperation;
            pastText = "";
            textBoxForCalculation.Text = "";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBoxForCalculation.Text);
            characterOfOperation = '/';
            firstPartOfCalculation.Text = textBoxForCalculation.Text + ' ' + characterOfOperation;
            pastText = "";
            textBoxForCalculation.Text = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBoxForCalculation.Text);
            characterOfOperation = '*';
            firstPartOfCalculation.Text = textBoxForCalculation.Text + ' ' + characterOfOperation;
            pastText = "";
            textBoxForCalculation.Text = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBoxForCalculation.Text);
            characterOfOperation = '+';
            firstPartOfCalculation.Text = textBoxForCalculation.Text + ' ' + characterOfOperation;
            pastText = "";
            textBoxForCalculation.Text = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            string newText = commandsForCalculation.PeformCommands(value1, int.Parse(textBoxForCalculation.Text), characterOfOperation).ToString();
            firstPartOfCalculation.Text = "";
            pastText = "";
            textBoxForCalculation.Text = newText;
            equalButton.Enabled = false;
        }
    }
}
