using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Double initialValue;
        Double nextValue;
        Double result;
        String operationRun;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button(object sender, EventArgs e)
        {
            if(textBox1.Text == "Syntax Error")
            {
                textBox1.Clear();
                Button button = (Button)sender;
                textBox1.Text = textBox1.Text + button.Text;
            }
            else 
            {
                Button button = (Button)sender;
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        private void operation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationRun = button.Text;
            initialValue = Double.Parse(textBox1.Text);
            textBox1.Clear();
            CurrentOperation.Text = initialValue + " " + operationRun;
        }

        private void Clear_Entry(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void EqualsOperator(object sender, EventArgs e)
        {
            switch (operationRun)
            {
                case "+":
                    nextValue = Double.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text = (initialValue + nextValue).ToString();
                    break;
                case "-":
                    nextValue = Double.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text = (initialValue - nextValue).ToString();
                    break;
                case "*":
                    nextValue = Double.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text = (initialValue * nextValue).ToString();
                    break;
                case "/":
                    nextValue = Double.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text = (initialValue / nextValue).ToString();
                    break;
                case "^":
                    nextValue = Double.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text = (Math.Pow(initialValue, nextValue)).ToString();
                    break;
                default:
                    textBox1.Text = "Syntax Error";
                    break;
            }
        }

        private void ClearAll(object sender, EventArgs e)
        {
            textBox1.Clear();
            CurrentOperation.Text = "";
            operationRun = "";
            initialValue = 0;
            nextValue = 0;
        }
    }
}
