using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDemo
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private Calculator calc = new Calculator();
        private void frmCalculator_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = calc.DisplayString;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calc.Clear();
            txtDisplay.Text = calc.DisplayString;
        }

        // This event handler method handles the 0 through 9 keys
        private void btnNumber_Click(object sender, EventArgs e)
        {
            calc.Append(((Button)sender).Tag.ToString());
            txtDisplay.Text = calc.DisplayString;
        }
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            // Create the method RemoveLast() in the Calculator class
            //calc.RemoveLast();
            txtDisplay.Text = calc.DisplayString;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            // Create the method ToggleSign() in the Caclulator class file
            // then remove the comment below
            
            //calc.ToggleSign();
            txtDisplay.Text = calc.DisplayString;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            // Create the method AddDecimalPoint() 
            // Be sure to append a leading zero for "0."

            //calc.AddDecimalPoint();
            txtDisplay.Text = calc.DisplayString;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calc.Add();
            txtDisplay.Text = calc.DisplayString;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                calc.Equals();
                txtDisplay.Text = calc.DisplayString;
            }
            catch (DivideByZeroException)
            {
                calc.Clear();
                txtDisplay.Text = "Cannot divide by zero";
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            // Create the missing method
            //calc.Subtract();
            txtDisplay.Text = calc.DisplayString;

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            // Create the missing method
            //calc.Multiply();
            txtDisplay.Text = calc.DisplayString;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            // Create the missing method
            //calc.Divide();
            txtDisplay.Text = calc.DisplayString;
        }

    }
}
