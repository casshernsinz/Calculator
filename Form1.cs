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
        //Double result;
        String operationRun;
        List<string> history = new List<string>();
        Boolean oprSolved = false;
        Boolean oprInvoked = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button(object sender, EventArgs e)
        {
            if(txtBox.Text == "Syntax Error" || oprInvoked == true)
            {
                txtBox.Clear();
                Button button = (Button)sender;
                txtBox.Text = txtBox.Text + button.Text;
            }
            else if(oprInvoked == false)
            {
                Button button = (Button)sender;
                txtBox.Text = txtBox.Text + button.Text;
            }
        }

        private void operation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationRun = button.Text;
            initialValue = Double.Parse(txtBox.Text);
            txtBox.Clear();
            curOpr.Text = initialValue + " " + operationRun;
            history.Add(curOpr.Text + nextValue);
        }

        private void EqualsOperator(object sender, EventArgs e)
        {
            switch (operationRun)
            {
                case "+":
                    nextValue = Double.Parse(txtBox.Text);
                    txtBox.Clear();
                    txtBox.Text = (initialValue + nextValue).ToString();
                    operationRun = "";
                    curOpr.Text = "";
                    oprInvoked = true;
                    if(oprInvoked == true && oprSolved != true)
                    {

                    }
                    break;
                case "-":
                    nextValue = Double.Parse(txtBox.Text);
                    txtBox.Clear();
                    txtBox.Text = (initialValue - nextValue).ToString();
                    operationRun = "";
                    curOpr.Text = "";
                    oprInvoked = true;
                    break;
                case "*":
                    nextValue = Double.Parse(txtBox.Text);
                    txtBox.Clear();
                    txtBox.Text = (initialValue * nextValue).ToString();
                    operationRun = "";
                    curOpr.Text = "";
                    oprInvoked = true;
                    break;
                case "/":
                    nextValue = Double.Parse(txtBox.Text);
                    txtBox.Clear();
                    txtBox.Text = (initialValue / nextValue).ToString();
                    operationRun = "";
                    curOpr.Text = "";
                    oprInvoked = true;
                    break;
                case "^":
                    nextValue = Double.Parse(txtBox.Text);
                    txtBox.Clear();
                    txtBox.Text = (Math.Pow(initialValue, nextValue)).ToString();
                    operationRun = "";
                    curOpr.Text = "";
                    oprInvoked = true;
                    break;
                default:
                    txtBox.Text = txtBox.Text;
                    break;
            }
        }
        private void Clear_Entry(object sender, EventArgs e)
        {
            txtBox.Clear();
        }

        private void ClearAll(object sender, EventArgs e)
        {
            txtBox.Clear();
            curOpr.Text = "";
            operationRun = "";
            initialValue = 0;
            nextValue = 0;
            oprSolved = false;
            oprInvoked = false;
        }
    }
}
