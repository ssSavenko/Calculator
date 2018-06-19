using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string pastText = "";
        bool IsLableFilled = false;

        public Form1()
        {
            InitializeComponent();
            firstPartOfCalculation.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i;
            if(!int.TryParse(textBoxForCalculation.Text, out i) && textBoxForCalculation.Text.Length != 0)
            {
                textBoxForCalculation.Text = pastText; 
            }
            else
            {
                pastText = textBoxForCalculation.Text;
            }

            if (firstPartOfCalculation.Text.Length != 0)
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
            firstPartOfCalculation.Text = "";
            textBoxForCalculation.Text = "";
        }

        private void buttonWith1Value_Click(object sender, EventArgs e)
        {
            textBoxForCalculation.Text += "1";
        }

        private void buttonWith2Value_Click(object sender, EventArgs e)
        {

        }

        private void buttonWith3Value_Click(object sender, EventArgs e)
        {

        }

        private void buttonWith4Value_Click(object sender, EventArgs e)
        {

        }

        private void buttonWith5Value_Click(object sender, EventArgs e)
        {

        }

        private void buttonWith6Value_Click(object sender, EventArgs e)
        {

        }

        private void buttonWith7Value_Click(object sender, EventArgs e)
        {

        }

        private void buttonWith8Value_Click(object sender, EventArgs e)
        {

        }

        private void buttonWith9Value_Click(object sender, EventArgs e)
        {

        }
    }
}
