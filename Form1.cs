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
        Double resultValue = 0;
        String operationRun = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
            isOperationPerformed = false;
        }

        private void operation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationRun = button.Text;
            resultValue = Double.Parse(textBox1.Text);
            CurrentOperation.Text = resultValue + " " + operationRun;
            isOperationPerformed = true;
        }

        private void Clear_Entry(object sender, EventArgs e)
        {
            //textBox1.Text = "0";
            resultValue = 0;
            textBox1.Clear();
        }

        private void EqualsOperator(object sender, EventArgs e)
        {
            switch (operationRun)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }
    }
}
