namespace CLCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display a menu of arithmetic operations and instructions to exit
            Console.WriteLine("Arithmetic Operations: \n1. Addition\n2. Substraction\n3. Multiplication\n4. Division\nPress 0 to Exit.");

            // Declare variables to store menu selection and input values
            string menu = "";
            int menuNumber = 0;

            // Prompt user to select an arithmetic operation
            Console.WriteLine("\nWhich operation would you like to execute?");

            // Loop until user selects 0 to exit
            do
            {
                // Read user input for menu selection
                menu = Console.ReadLine();

                // Check if user input is a valid integer
                if (int.TryParse(menu, out menuNumber))
                {
                    // Check if user selects 0 to exit
                    if (menuNumber == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Exiting Program...");
                    }
                    else
                    {
                        // Check if user selects a valid arithmetic operation (1-4)
                        if (menuNumber >= 1 && menuNumber <= 4)
                        {
                            // Declare variables to store input values and calculation results
                            string numString1, numString2;
                            double num1, num2, result;

                            // Perform the selected arithmetic operation based on the user input
                            switch (menuNumber)
                            {
                                case 1:
                                    // Addition operation selected
                                    Console.WriteLine("\nYou Selected: Addition\n");
                                    Console.WriteLine("Enter the first number");
                                    numString1 = Console.ReadLine();

                                    // Check if the user inputs a valid number for the first operand
                                    if (double.TryParse(numString1, out num1))
                                    {
                                        Console.WriteLine("Enter the second number");
                                        numString2 = Console.ReadLine();

                                        // Check if the user inputs a valid number for the second operand
                                        if (double.TryParse(numString2, out num2))
                                        {
                                            // Calculate the sum of the two operands and display the result
                                            result = num1 + num2;
                                            Console.WriteLine($"\n{num1} + {num2} = {result}");

                                            // Wait for the user to press a key to continue and clear the screen
                                            Console.WriteLine("\nPress any key to continue...");
                                            Console.ReadKey();
                                            Console.Clear();

                                            // Display the arithmetic operation menu again
                                            Console.WriteLine("Arithmetic Operations: \n1. Addition\n2. Substraction\n3. Multiplication\n4. Division\nPress 0 to Exit.\n\nSelect an option from the menu");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Only numbers allowed. Select an option from the menu");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Only numbers allowed. Select an option from the menu");
                                    }
                                    break;
                                case 2:
                                    // Subtraction operation selected
                                    Console.WriteLine("\nYou Selected: Substraction\n");
                                    Console.WriteLine("Enter the first number");
                                    numString1 = Console.ReadLine();

                                    // Check if the user inputs a valid number for the first operand
                                    if (double.TryParse(numString1, out num1))
                                    {
                                        Console.WriteLine("Enter the second number");
                                        numString2 = Console.ReadLine();

                                        // Check if the user inputs a valid number for the second operand
                                        if (double.TryParse(numString2, out num2))
                                        {
                                            // Calculate the difference between the two operands and display the result
                                            result = num1 - num2;
                                            Console.WriteLine($"\n{num1} - {num2} = {result}");

                                            // Wait for the user to press a key to continue and clear the screen
                                            Console.WriteLine("\nPress any key to continue...");
                                            Console.ReadKey();
                                            Console.Clear();

                                            // Display the arithmetic operation menu again
                                            Console.WriteLine("Arithmetic Operations: \n1. Addition\n2. Substraction\n3. Multiplication\n4. Division\nPress 0 to Exit.\n\nSelect an option from the menu");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Only numbers allowed. Select an option from the menu");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Only numbers allowed. Select an option from the menu");
                                    }
                                    break;
                                case 3:
                                    // Multiplication operation selected
                                    Console.WriteLine("\nYou Selected: Multiplication\n");
                                    Console.WriteLine("Enter the first number");
                                    numString1 = Console.ReadLine();

                                    // Check if the user inputs a valid number for the first operand
                                    if (double.TryParse(numString1, out num1))
                                    {
                                        Console.WriteLine("Enter the second number");
                                        numString2 = Console.ReadLine();

                                        // Check if the user inputs a valid number for the second operand
                                        if (double.TryParse(numString2, out num2))
                                        {
                                            // Calculate the multiplication the two operands and display the result
                                            result = num1 * num2;
                                            Console.WriteLine($"\n{num1} * {num2} = {result}");

                                            // Wait for the user to press a key to continue and clear the screen
                                            Console.WriteLine("\nPress any key to continue...");
                                            Console.ReadKey();
                                            Console.Clear();

                                            // Display the arithmetic operation menu again
                                            Console.WriteLine("Arithmetic Operations: \n1. Addition\n2. Substraction\n3. Multiplication\n4. Division\nPress 0 to Exit.\n\nSelect an option from the menu");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Only numbers allowed. Select an option from the menu");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Only numbers allowed. Select an option from the menu");
                                    }
                                    break;
                                case 4:
                                    // Division operation selected
                                    Console.WriteLine("\nYou Selected: Division\n");
                                    Console.WriteLine("Enter the first number");
                                    numString1 = Console.ReadLine();

                                    // Check if the user inputs a valid number for the first operand
                                    if (double.TryParse(numString1, out num1))
                                    {
                                        Console.WriteLine("Enter the second number");
                                        numString2 = Console.ReadLine();

                                        // Check if the user inputs a valid number for the second operand
                                        if (double.TryParse(numString2, out num2))
                                        {
                                            // Calculate the division of the two operands and display the result
                                            result = num1 / num2;
                                            Console.WriteLine($"\n{num1} ÷ {num2} = {result}");

                                            // Wait for the user to press a key to continue and clear the screen
                                            Console.WriteLine("\nPress any key to continue...");
                                            Console.ReadKey();
                                            Console.Clear();

                                            // Display the arithmetic operation menu again
                                            Console.WriteLine("Arithmetic Operations: \n1. Addition\n2. Substraction\n3. Multiplication\n4. Division\nPress 0 to Exit.\n\nSelect an option from the menu");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Only numbers allowed. Select an option from the menu");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Only numbers allowed. Select an option from the menu");
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Numbers has to be between 1-4. Numbers outside this range are not allowed. Try again");
                        }
                    }
                }
                else
                {
                    // We display an error indicating the user to write a number and assign a 5 to menuNumber variable because if the user writes a letter, menuNumber will be 0 and the program will exit. 
                    Console.WriteLine("Only numbers accepted. Try again");
                    menuNumber += 5;

                }
                // If the user write a 0, the loop will end and the program will exit.
            } while (menuNumber != 0);
        }
    }
}