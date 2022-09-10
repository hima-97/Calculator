using System.Data;
using System.Globalization;

namespace Calculator
{
    public partial class Calculator : Form
    {
        // Variable to track current number:
        public string currentNumber = "";

        // Variable to track first operand of expression to evaluate:
        public string firstOperand = "";

        // Variable to track second operand of expression to evaluate:
        public string secondOperand = "";

        // Variable to track current number to use in expression:
        public string currentNumberInExpression = "";

        // Variable to track first operand to use in expression:
        public string firstOperandInExpression = "";

        // Variable to track second operand to use in expression:
        public string secondOperandInExpression = "";

        // Variable to track current operator of expression to evaluate:
        public string currentOperator = "";

        // Variable to track the result of expression evaluated:
        public string myResult = "";

        // Variable to track current expression to evaluate:
        public string currentExpression = "";

        // List of strings (i.e. expressions) for history:
        List<string> history = new List<string>();

        // "Calculator" form constructor:
        public Calculator()
        {
            InitializeComponent();
        }

        // Function to display number clicked onto the textbox:
        public void numberClicked(object sender, EventArgs e)
        {
            // Limiting input number to 13 digits max:
            if (currentNumber.Length < 13)
            {
                // For when "." button is clicked:
                if ((sender as Button).Text == ".")
                {
                    // Boolean that returns true if current number has . and returns false otherwise:
                    Boolean isThereDot = currentNumber.Contains('.');

                    // Adding "." to the current number only if it does not alreay have one:
                    if (!isThereDot)
                    {
                        if (currentNumber == "")
                            currentNumber = "0" + (sender as Button).Text;
                        else
                            currentNumber += (sender as Button).Text;
                    }
                }
                else
                {
                    // Adding clicked number to "currentNumber" string:
                    currentNumber += (sender as Button).Text;
                }

                // Displaying current number onto the textbox:
                textBox.Text = currentNumber;
                currentNumberInExpression = currentNumber;
            }
        }

        // Function to read user input (i.e. numbers) from textbox:
        public void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If it's not a number or ".", then do not allow user to type onto textbox:
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // If there is already a ".", then do not allow user to type another "." onto textbox:
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // Function to clear all inputs and reset everything, except history:
        public void clearEverything()
        {
            // Resetting text box:
            textBox.Text = "0";

            // Resetting operator:
            currentOperator = "";

            // Resetting current expression:
            currentExpression = "";

            // Resetting current number:
            currentNumber = "";

            // Resetting first operand:
            firstOperand = "";

            // Resetting second operand:
            secondOperand = "";

            // Resetting current number to use in expression:
            currentNumberInExpression = "";

            // Resetting first operand to use in expression:
            firstOperandInExpression = "";

            // Resetting second operand to use in expression:
            secondOperandInExpression = "";

            // Resetting result:
            myResult = "";
        }

        // Function to format number to scientific notation (i.e. e+ or e-) if it is too large:
        public string scientificNotation(string myCurrentNumber)
        {
            double currentNumber = Convert.ToDouble(myCurrentNumber);
            string currentNumberString = currentNumber.ToString("e", CultureInfo.CreateSpecificCulture("en-US"));
            // Formatting current number from 3.333333e+000 to just 3.333333 for example:
            currentNumber = double.Parse(currentNumberString, CultureInfo.InvariantCulture) * 1.0;
            myCurrentNumber = Convert.ToString(currentNumber);
            return myCurrentNumber;
        }

        // Function to perform calculation:
        public void evaluateExpression()
        {
            // Re-formatting first operand if it contains scientific notation (i.e. e+ or e-)
            if (firstOperand.Contains("e") || firstOperand.Contains("E"))
            {
                double myFirstOperand = double.Parse(firstOperand, CultureInfo.InvariantCulture);
                firstOperand = Convert.ToString(myFirstOperand);
            }
            // Re-formatting second operand if it contains scientific notation (i.e. e+ or e-)
            if (secondOperand.Contains("e") || secondOperand.Contains("E"))
            {
                double mySecondOperand = double.Parse(secondOperand, CultureInfo.InvariantCulture);
                secondOperand = Convert.ToString(mySecondOperand);
            }

            // Computing current expression:
            if (currentOperator == "+")
            {
                // Setting up current expression in order to perform calculations
                currentExpression = firstOperand + " " + currentOperator + " " + secondOperand;

                myResult = new DataTable().Compute(currentExpression, null).ToString();

                // Re-formatting result to scientific notation (i.e. e+ or e-) if it is too large:
                if (myResult.Length > 13)
                {
                    myResult = scientificNotation(myResult);
                }
            }
            else if (currentOperator == "-")
            {
                // Setting up current expression in order to perform calculations
                currentExpression = firstOperand + " " + currentOperator + " " + secondOperand;

                myResult = new DataTable().Compute(currentExpression, null).ToString();

                // Re-formatting result to scientific notation (i.e. e+ or e-) if it is too large:
                if (myResult.Length > 13)
                {
                    myResult = scientificNotation(myResult);
                }
            }
            else if (currentOperator == "×")
            {
                myResult = Convert.ToString(Convert.ToDouble(firstOperand) * Convert.ToDouble(secondOperand));

                // Re-formatting result to scientific notation (i.e. e+ or e-) if it is too large:
                if (myResult.Length > 13)
                {
                    myResult = scientificNotation(myResult);
                }
            }
            else if (currentOperator == "÷")
            {
                myResult = Convert.ToString(Convert.ToDouble(firstOperand) / Convert.ToDouble(secondOperand));

                // Re-formatting result to scientific notation (i.e. e+ or e-) if it is too large:
                if (myResult.Length > 13)
                {
                    myResult = scientificNotation(myResult);
                }
            }
            else if (currentOperator == "%")
            {
                myResult = Convert.ToString(Convert.ToDouble(firstOperand) % Convert.ToDouble(secondOperand));

                // Re-formatting result to scientific notation (i.e. e+ or e-) if it is too large:
                if (myResult.Length > 13)
                {
                    myResult = scientificNotation(myResult);
                }
            }

            // Display result back to the user:
            textBox.Text = myResult;

            // Adding current operands, operator, and result to current expression:
            currentExpression = firstOperandInExpression + " " + currentOperator + " " + secondOperandInExpression + " = " + myResult;

            // Adding current expression to history list:
            history.Add(currentExpression);

            // Resetting first operand for next expression:
            firstOperand = "";

            // Resetting second operand for next expression:
            secondOperand = "";

            // Resetting first operand to use in expression:
            firstOperandInExpression = "";

            // Resetting second operand to use in expression:
            secondOperandInExpression = "";

            // Resetting current number in expression:
            currentNumberInExpression = "";

            // Resetting current expression:
            currentExpression = "";

            // Resetting operator:
            currentOperator = "";

            // Assigning result to current number:
            currentNumber = myResult;
            currentNumberInExpression = currentNumber;

            // Resetting result:
            myResult = "";
        }

        // Function to use when +, -, ×, or ÷ buttons are clicked:
        public void operatorClicked(object sender, EventArgs e)
        {
            // If current number is NaN, then clear all inputs and reset everything, except history:
            if (currentNumber == "NaN")
            {
                clearEverything();
            }
            else
            {
                // Assign current number to "secondOperand" and evaluate expression if "firstOperand" is not empty:
                if (firstOperand != "" && currentOperator != "" && secondOperand == "" && currentNumber != "")
                {
                    secondOperand = currentNumber;
                    secondOperandInExpression = currentNumberInExpression;
                    evaluateExpression();
                }
                // This is the case when user clicks an operator when "currentOperator" is not empty, but "firstOperand" is empty:
                if (firstOperand == "" && currentOperator != "" && currentNumber != "")
                {
                    firstOperand = currentNumber;
                    firstOperandInExpression = currentNumberInExpression;
                    currentNumber = "";
                    currentNumberInExpression = "";
                }
                // This is the case when user clicks an operator when "currentOperator" and "firstOperand" are empty:
                // (Note: This also applies for when user clicks an operator after expression is evaluated with "=" button)
                else if (firstOperand == "" && currentOperator == "")
                {
                    // If current number is empty, then assign "0" to it:
                    // (i.e. this is the case when user clicks operator before a number)
                    if (currentNumber == "")
                    {
                        currentNumber = "0";
                        currentNumberInExpression = "0";
                    }

                    firstOperand = currentNumber;
                    firstOperandInExpression = currentNumberInExpression;

                    // Resetting current number for second operand:
                    currentNumber = "";
                    currentNumberInExpression = "";
                }

                // Assign clicked operator in "currentOperator" string:
                currentOperator = (sender as Button).Text;
            }
        }

        // Function for equals button:
        public void equalsClicked(object sender, EventArgs e)
        {
            // If current number is NaN, then clear all inputs and reset everything, except history:
            if (currentNumber == "NaN")
            {
                clearEverything();
            }
            else
            {
                if (firstOperand != "" && currentOperator != "" && currentNumber != "" && secondOperand == "")
                {
                    secondOperand = currentNumber;
                    secondOperandInExpression = currentNumberInExpression;
                    evaluateExpression();
                }
                // This is the case when user clicks "=" with only the current number in memory:
                else if (currentNumber != "")
                {
                    textBox.Text = currentNumber;
                    currentExpression = currentNumberInExpression + " = " + currentNumber;
                    currentNumberInExpression = currentNumber;
                    history.Add(currentExpression);
                }
            }
        }

        // Function for C button (i.e. clear everything, except history):
        public void cButtonClicked(object sender, EventArgs e)
        {
            clearEverything();
        }

        // Function CE button (i.e. clear last entry):
        public void ceButtonClicked(object sender, EventArgs e)
        {
            textBox.Text = "0";

            // Resetting current number:
            currentNumber = "";
            currentNumberInExpression = "";

            // Resetting first operand if it is not empty while current operator is empty:
            if (currentOperator == "" && firstOperand != "")
            {
                firstOperand = "";
                firstOperandInExpression = "";
            }
        }

        // Function to erase last digit entered (i.e. backspace button):
        public void eraseButtonClicked(object sender, EventArgs e)
        {
            // If current output is not empty, remove the last entry:
            if (currentNumber.Length > 1)
            {
                currentNumber = currentNumber.Remove(currentNumber.Length - 1, 1);
                currentNumberInExpression = currentNumber;
                textBox.Text = currentNumber;
            }
            // If you are not in the middle of an expression:
            else if (currentOperator == "")
            {
                currentNumber = "";
                currentNumberInExpression = "";

                textBox.Text = "0";

                firstOperand = "";
                firstOperandInExpression = "";
            }
        }

        // Function for +/- button:
        public void plusMinusClicked(object sender, EventArgs e)
        {
            if (currentNumber != "")
            {
                // Formatting current number to use in expression:
                currentNumberInExpression = "negate(" + currentNumber + ")";

                double oppositeNumber = Convert.ToDouble(currentNumber);

                oppositeNumber = oppositeNumber * (-1);

                currentNumber = Convert.ToString(oppositeNumber);

                textBox.Text = currentNumber;
            }
        }

        // Function for square root button:
        public void squareRootClicked(object sender, EventArgs e)
        {
            if (currentNumber != "")
            {
                // Formatting current number to use in expression:
                currentNumberInExpression = "sqrt(" + currentNumberInExpression + ")";

                // Performing square root of current number:
                currentNumber = Convert.ToString(Math.Sqrt(Convert.ToDouble(currentNumber)));

                // Re-formatting current number to scientific notation (i.e. e+ or e-) if it is too large:
                if (currentNumber.Length > 13)
                {
                    currentNumber = scientificNotation(currentNumber);
                }
                
                textBox.Text = currentNumber;
            }
        }

        // Function for square button:
        public void squareClicked(object sender, EventArgs e)
        {
            if (currentNumber != "")
            {
                // Formatting current number to use in expression:
                currentNumberInExpression = "(" + currentNumberInExpression + ")^2";

                // Performing square root of current number:
                currentNumber = Convert.ToString(Math.Pow(Convert.ToDouble(currentNumber), 2));

                // Re-formatting current number to scientific notation (i.e. e+ or e-) if it is too large:
                if (currentNumber.Length > 13)
                {
                    currentNumber = scientificNotation(currentNumber);
                }

                textBox.Text = currentNumber;
            }
        }

        // Function for inverse button:
        public void inverseClicked(object sender, EventArgs e)
        {
            if (currentNumber != "")
            {
                // Formatting current number to use in expression:
                currentNumberInExpression = "1/(" + currentNumberInExpression + ")";

                // Performing square root of current number:
                currentNumber = Convert.ToString(1 / (Convert.ToDouble(currentNumber)));

                // Re-formatting current number to scientific notation (i.e. e+ or e-) if it is too large:
                if (currentNumber.Length > 13)
                {
                    currentNumber = scientificNotation(currentNumber);
                }

                textBox.Text = currentNumber;
            }
        }

        // Function for history button:
        public void historyClicked(object sender, EventArgs e)
        {
            // Displaying each expression stored in the history:
            for (int i = 0; i < history.Count; i++)
            {
                historyTextBox.Text += history[i].ToString() + System.Environment.NewLine + System.Environment.NewLine;
            }

            // Showing history textbox:
            if (this.historyPanel.Visible == false)
            {
                this.historyPanel.Visible = true;
                this.historyTextBox.Visible = true;
            }
            // Hiding history textbox:
            else
            {
                this.historyPanel.Visible = false;
                this.historyTextBox.Visible = false;
                historyTextBox.Text = "";
            }
        }
    }
}