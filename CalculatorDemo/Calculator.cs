using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemo
{
    public class Calculator
    {
        //The display string is constructed as the user clicks on digits
        private string displayString = "";

        // Determines if the calculator can accept a new numeric value
        private bool isNewValue;

        // Makes sure there is only one decimal point entered
        private bool hasDecimal;

        //These two operands will be used in the math function
        private decimal operand1;
        private decimal operand2;

        //Define the operation type and assign an integer to each one
        private Operation op;
        private enum Operation { Add, Subtract, Multiply, Divide, None };

        public Calculator()
        {
            Clear();
        }

        public void Clear()
        {
            //reset all fields
            displayString = "";
            hasDecimal = false;
            isNewValue = true;
            operand1 = 0;
            operand2 = 0;
            op = Operation.None;
        }

        // The public DisplayString property returns "0"
        //    if the private field displayString is null
        public string DisplayString =>
            string.IsNullOrEmpty(displayString) ? "0" : displayString;

        private decimal displayValue => Convert.ToDecimal(DisplayString);

        public void Append(string value)
        {
            if (isNewValue)
            {
                displayString = "";
                hasDecimal = false;
                isNewValue = false;
            }
            // Don't append "0" to a display string of "0"
            // to avoid values like "00000"
            displayString += (displayString == "0" && value == "0") ? "" : value;
        }

        public void Add()
        {
            SetValuesForOperation(Operation.Add);
        }
        private void SetValuesForOperation(Operation newop)
        {
            op = newop;

            // set the first operand
            operand1 = displayValue;

            // reset booleans
            hasDecimal = false;
            isNewValue = true;

        }
        public void Equals()
        {
            operand2 = displayValue;
            decimal calculatedValue = 0;
            int intop = Convert.ToInt32(op);

            switch (intop)
            {
                case 0:
                    calculatedValue = operand1 + operand2;
                    break;

                case 1:
                    calculatedValue = operand1 - operand2;
                    break;

                case 2:
                    calculatedValue = operand1 * operand2;
                    break;

                case 3:
                    calculatedValue = operand1 / operand2;
                    break;

                default:
                    calculatedValue = 0;
                    break;

            }

            displayString = calculatedValue.ToString();

            //reset values
            op = Operation.None;
            hasDecimal = false;
            isNewValue = true;
        }
        // Add missing methods to this file
        // RemoveLast()
        // AddDecimalPoint()
        // Subtract()
        // Multiply()
        // Divide()


    }
}
