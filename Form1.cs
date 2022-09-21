using System;
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

        // Boolean to track if "=" has been clicked:
        public Boolean equalBeenClicked = false;

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

        // Function for when a number or "." is clicked:
        public void numberClicked(object sender, EventArgs e)
        {
            // Limiting input number to 13 digits max:
            if (currentNumber.Length < 13)
            {
                // If "=" has been clicked, then next time user types a number it will be a brand new number:
                if (equalBeenClicked == true)
                {
                    currentNumber = "";
                    currentNumberInExpression = "";
                    equalBeenClicked = false;
                }

                // For when "." button is clicked:
                if ((sender as Button).Text == ".")
                {
                    // Boolean that returns true if current number has "." and returns false otherwise:
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

                // Adding current number to current number to use in expression:
                currentNumberInExpression = currentNumber;
            }
        }

        // Function to clear all inputs and reset everything, except history:
        public void clearEverything()
        {
            textBox.Text = "0";
            currentExpressionTextBox.Text = "";
            currentOperator = "";
            currentExpression = "";
            currentNumber = "";
            firstOperand = "";
            secondOperand = "";
            currentNumberInExpression = "";
            firstOperandInExpression = "";
            secondOperandInExpression = "";
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

        // Function to perform calculations:
        public void evaluateExpression()
        {
            // Formatting first operand if it contains scientific notation (i.e. e+ or e-)
            if (firstOperand.Contains("e") || firstOperand.Contains("E"))
            {
                double myFirstOperand = double.Parse(firstOperand, CultureInfo.InvariantCulture);
                firstOperand = Convert.ToString(myFirstOperand);
            }
            // Formatting second operand if it contains scientific notation (i.e. e+ or e-)
            if (secondOperand.Contains("e") || secondOperand.Contains("E"))
            {
                double mySecondOperand = double.Parse(secondOperand, CultureInfo.InvariantCulture);
                secondOperand = Convert.ToString(mySecondOperand);
            }

            // Computing current expression:
            if (currentOperator == "+" || currentOperator == "-")
            {
                // Setting up current expression in order to perform calculations:
                currentExpression = firstOperand + " " + currentOperator + " " + secondOperand;

                myResult = new DataTable().Compute(currentExpression, null).ToString();
            }
            else if (currentOperator == "×" || currentOperator == "*")
            {
                myResult = Convert.ToString(Convert.ToDouble(firstOperand) * Convert.ToDouble(secondOperand));
            }
            else if (currentOperator == "÷" || currentOperator == "/")
            {
                myResult = Convert.ToString(Convert.ToDouble(firstOperand) / Convert.ToDouble(secondOperand));
            }
            else if (currentOperator == "%")
            {
                myResult = Convert.ToString(Convert.ToDouble(firstOperand) % Convert.ToDouble(secondOperand));
            }

            // Formatting result to scientific notation (i.e. e+ or e-) if it is too large:
            if (myResult.Length > 13)
            {
                myResult = scientificNotation(myResult);
            }

            // Display result back to the user:
            textBox.Text = myResult;

            // Adding current operands, operator, and result to current expression:
            currentExpression = firstOperandInExpression + " " + currentOperator + " " + secondOperandInExpression + " = " + myResult;

            // Displaying current expression without the result onto the "currentExpressionTextBox":
            this.currentExpressionTextBox.Text = firstOperandInExpression + " " + currentOperator + " " + secondOperandInExpression + " =";

            // Adding current expression to history list:
            history.Add(currentExpression);

            // Resetting first operand for next expression:
            firstOperand = "";
            firstOperandInExpression = "";

            // Resetting second operand for next expression:
            secondOperand = "";
            secondOperandInExpression = "";

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

        // Function for when +, -, ×, ÷, or % buttons are clicked:
        public void operatorClicked(object sender, EventArgs e)
        {
            // If current number is NaN or infinity then clear all inputs and reset everything, except history:
            if (currentNumber == "NaN" || (double.TryParse(currentNumber, out double myDouble) && Double.IsInfinity(myDouble)))
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
                // (Example: click 5, then +, then 2, then x, then 3, then -, etc.)
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

                // Displaying current first operand and operator:
                currentExpressionTextBox.Text = firstOperandInExpression + " " + (sender as Button).Text;
            }
        }

        // Function for equals button:
        public void equalsClicked(object sender, EventArgs e)
        {
            // If current number is NaN or infinity then clear all inputs and reset everything, except history:
            if (currentNumber == "NaN" || (double.TryParse(currentNumber, out double myDouble) && Double.IsInfinity(myDouble)))
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
                    equalBeenClicked = true;
                }
                // This is the case when user clicks "=" with only the current number in memory:
                else if (currentNumber != "")
                {
                    currentExpression = currentNumberInExpression + " = " + currentNumberInExpression;
                    currentExpressionTextBox.Text = currentNumberInExpression + " =";
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
            // If current number has only one digit:
            else if (currentNumber.Length == 1)
            {
                currentNumber = "";
                currentNumberInExpression = "";
                textBox.Text = "0";
            }
        }

        // Function for square, square root, inverse, and +/- (i.e. negate function):
        public void functionClicked(object sender, EventArgs e)
        {
            if (currentNumber != "")
            {
                // For square:
                if (sender == this.square)
                {
                    // Formatting current number to use in expression:
                    currentNumberInExpression = "(" + currentNumberInExpression + ")^2";

                    currentNumber = Convert.ToString(Math.Pow(Convert.ToDouble(currentNumber), 2));
                }
                // For square root:
                else if (sender == this.squareRoot)
                {
                    // Formatting current number to use in expression:
                    currentNumberInExpression = "sqrt(" + currentNumberInExpression + ")";

                    currentNumber = Convert.ToString(Math.Sqrt(Convert.ToDouble(currentNumber)));
                }
                // For inverse:
                else if (sender == this.inverse)
                {
                    // Formatting current number to use in expression:
                    currentNumberInExpression = "1/(" + currentNumberInExpression + ")";

                    currentNumber = Convert.ToString(1 / (Convert.ToDouble(currentNumber)));
                }
                // For plus/minus:
                else if (sender == this.plusMinus)
                {
                    // Formatting current number to use in expression:
                    currentNumberInExpression = "negate(" + currentNumberInExpression + ")";

                    double oppositeNumber = Convert.ToDouble(currentNumber);
                    oppositeNumber = oppositeNumber * (-1);
                    currentNumber = Convert.ToString(oppositeNumber);
                }

                // Displaying first operand and current number in expression:
                if (firstOperandInExpression != "" && currentOperator != "")
                {
                    currentExpressionTextBox.Text = firstOperandInExpression + " " + currentOperator + " " + currentNumberInExpression;
                }
                else
                    // Displaying current number in expression:
                    currentExpressionTextBox.Text = currentNumberInExpression;

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
            // Displaying each expression stored in the history onto the history textbox:
            for (int i = 0; i < history.Count; i++)
            {
                historyTextBox.Text += history[i].ToString() + System.Environment.NewLine + System.Environment.NewLine;
            }

            // Showing history textbox:
            if (this.historyPanel.Visible == false)
            {
                this.historyPanel.Visible = true;
                this.historyTextBox.Visible = true;
                this.currentExpressionTextBox.Visible = false;
            }
            // Hiding history textbox:
            else
            {
                this.historyPanel.Visible = false;
                this.historyTextBox.Visible = false;
                this.currentExpressionTextBox.Visible = true;
                historyTextBox.Text = "";
            }
        }

        // Function to read user input (i.e. numbers) from textbox:
        public void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // This won't display any user input onto the textbox:
            // (Note: rest of function decides how to deal with keys pressed and what to display)
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // If it's a number or ".", then add it to the current number:
            if (!char.IsControl(e.KeyChar) && (char.IsDigit(e.KeyChar) || (e.KeyChar == '.')))
            {
                // Limiting input number to 13 digits max:
                if (currentNumber.Length < 13)
                {
                    // For when '.' key is pressed:
                    if (e.KeyChar == '.')
                    {
                        // Boolean that returns true if current number has . and returns false otherwise:
                        Boolean isThereDot = currentNumber.Contains('.');

                        // Adding '.' to the current number only if it does not alreay have one:
                        if (!isThereDot)
                        {
                            if (currentNumber == "")
                                currentNumber = "0" + e.KeyChar;
                            else
                                currentNumber += e.KeyChar;
                        }
                    }
                    else
                    {
                        // Adding clicked number to "currentNumber" string:
                        currentNumber += e.KeyChar;
                    }

                    // Displaying current number onto the textbox:
                    textBox.Text = currentNumber;

                    // Adding current number to current number to use in expression:
                    currentNumberInExpression = currentNumber;
                }
            }

            // For when backspace (i.e. erase) key is pressed:
            if (e.KeyChar == '\b')
            {
                // If current output is not empty, remove the last entry:
                if (currentNumber.Length > 1)
                {
                    currentNumber = currentNumber.Remove(currentNumber.Length - 1, 1);
                    currentNumberInExpression = currentNumber;
                    textBox.Text = currentNumber;
                }
                // If current number has only one digit:
                else if (currentNumber.Length == 1)
                {
                    currentNumber = "";
                    currentNumberInExpression = "";

                    textBox.Text = "0";
                }
                else
                    e.Handled = true; // Backspace key is not applied
            }

            // For when +, -, ×, ÷, or % keys are pressed:
            if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/' || e.KeyChar == '%')
            {
                // If current number is NaN or infinity then clear all inputs and reset everything, except history:
                if (currentNumber == "NaN" || (double.TryParse(currentNumber, out double myDouble) && Double.IsInfinity(myDouble)))
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
                    // (Example: click 5, then +, then 2, then x, then 3, then -, etc.)
                    if (firstOperand == "" && currentOperator != "" && currentNumber != "")
                    {
                        firstOperand = currentNumber;
                        firstOperandInExpression = currentNumberInExpression;
                        currentNumber = "";
                        currentNumberInExpression = "";
                    }
                    // This is the case when user presses an operator when "currentOperator" and "firstOperand" are empty:
                    // (Note: This also applies for when user presses an operator after expression is evaluated with "=" button)
                    else if (firstOperand == "" && currentOperator == "")
                    {
                        // If current number is empty, then assign "0" to it:
                        // (i.e. this is the case when user presses operator before a number)
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

                    // Assign pressed operator in "currentOperator" string:
                    currentOperator = e.KeyChar.ToString();

                    // Displaying current first operand and operator:
                    currentExpressionTextBox.Text = firstOperandInExpression + " " + e.KeyChar.ToString();
                }
            }

            // For when "=" or "enter" key is pressed:
            if (e.KeyChar == '=' || e.KeyChar == '\r')
            {
                // If current number is NaN or infinity then clear all inputs and reset everything, except history:
                if (currentNumber == "NaN" || (double.TryParse(currentNumber, out double myDouble) && Double.IsInfinity(myDouble)))
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
                        equalBeenClicked = true;
                    }
                    // This is the case when user clicks "=" with only the current number in memory:
                    else if (currentNumber != "")
                    {
                        currentExpression = currentNumberInExpression + " = " + currentNumberInExpression;
                        currentExpressionTextBox.Text = currentNumberInExpression + " =";
                        history.Add(currentExpression);
                    }
                }
            }
        }
    }
}