# Calculator Project

## Project Description

This project involves building a standard mathematical calculator with a graphical user interface (GUI). The application is a desktop software implemented using Windows Forms in the Microsoft .Net Framework.

## Functionality

The GUI-based calculator supports a variety of mathematical operations. Users can perform the following operations:

### Basic Operations
- **Addition**: Add two numbers.
- **Subtraction**: Subtract one number from another.
- **Multiplication**: Multiply two numbers.
- **Division**: Divide one number by another.
- **Modulo**: Find the remainder of the division of one number by another.

### Advanced Operations
- **Square**: Calculate the square of a number.
- **Square Root**: Calculate the square root of a number.
- **Inverse**: Calculate the reciprocal (inverse) of a number.
- **Negate**: Change the sign of a number (positive to negative or negative to positive).

### Other Features
- **Display History**: View the history of all operations performed.
- **Clear Expression (C)**: Clear the current expression.
- **Clear Operand (CE)**: Clear the current operand.

## User Interface

The calculator's user interface consists of buttons for numbers, basic operations, advanced operations, and utility functions. Additionally, it includes:
- **Text Box**: Displays the current number or result.
- **Current Expression Box**: Shows the current mathematical expression being evaluated.
- **History Panel**: Displays a history of all calculations performed.

## Tools and Concepts

The following tools and concepts were used in this project:
- **Languages**: C#
- **Framework**: Windows Forms Application
- **IDE**: Visual Studio
- **Concepts**: 
  - String Manipulation
  - Object-Oriented Programming (OOP)
  - Dynamic Memory Management
  - Recursive Algorithms

## File Descriptions

### Form1.cs
This file contains the main logic for the calculator's functionality. It handles user interactions, performs calculations, and updates the display. Key functions include:
- **Number Click Handling**: Manages input from number buttons.
- **Operator Handling**: Manages input from operation buttons.
- **Equals Handling**: Computes the result of the current expression.
- **Clear Functions**: Clear current expression or operand.
- **Function Handling**: Performs square, square root, inverse, and negate operations.
- **History Management**: Displays and manages the history of operations.

### Form1.Designer.cs
This file contains the auto-generated code for the layout and design of the calculator's user interface. It defines the properties and event handlers for all UI components.

### Program.cs
This file contains the entry point of the application. It initializes and runs the Calculator form. The `Main` method is marked with the `[STAThread]` attribute, which is necessary for Windows Forms applications.

## Running and Testing the Project

To run and test the full project, follow these steps:

1. **Clone the Repository**: Clone the project repository to your local machine.
2. **Build the Project**: Open the solution in Visual Studio and build the project.
3. **Locate the Executable**: Navigate to the `Calculator/bin/Debug/net6.0-windows` directory.
4. **Run the Application**: Execute the `Calculator.exe` file to launch the calculator application.

By following these steps, you can interact with the calculator and test its functionality.

## Conclusion

This calculator project demonstrates the implementation of a comprehensive calculator using Windows Forms and C#. It covers basic and advanced operations, user interface design, and dynamic memory management, showcasing the power of the .Net Framework for desktop application development.
