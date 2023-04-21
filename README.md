# CLCalculator
CLCalculator is a console application for performing basic arithmetic operations. It allows the user to select one of the four arithmetic operations: addition, subtraction, multiplication, or division. The program prompts the user to enter two operands and calculates the result based on the selected operation.

# Usage
To run the CLCalculator program, simply execute the CLCalculator.exe file from the command line. The program will display a menu of arithmetic operations and instructions to exit. To select an operation, enter the corresponding number and press enter. Then, enter the two operands and the program will display the result of the calculation. The program will then display the arithmetic operation menu again, allowing the user to perform additional calculations or exit the program by selecting 0.

# Program Flow
The CLCalculator program starts by displaying a menu of arithmetic operations and prompting the user to select an operation. The program then enters a loop, which continues until the user selects 0 to exit. Within the loop, the program reads the user's input for the selected operation and performs the corresponding calculation. The program checks if the user inputs a valid number for the operands and displays an error message if not. Once the calculation is complete, the program waits for the user to press a key before clearing the screen and displaying the arithmetic operation menu again. If the user selects 0 to exit, the program displays a message and exits.

# Namespace and Classes
The CLCalculator program is contained within the CLCalculator namespace and includes the Program class, which contains the Main method. The Program class is marked as internal, meaning it can only be accessed within the same assembly. The Main method is the entry point of the program and is responsible for displaying the arithmetic operation menu and reading user input. The program flow is then controlled by a do-while loop within the Main method.