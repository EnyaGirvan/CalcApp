void CalcApp()
{
	try
	{
		Console.WriteLine("Enter the first number: ");
		int firstNumber = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the second number: ");
		int secondNumber = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the operation (+, -, *, /): ");
		var operation = Convert.ToChar(Console.ReadLine());

        // int result must be placed above the switch statement to avoid scope issues
        // placed within switch block means it cannot access outside of it, so it has
		// to be declared at the top of the method to be accessible throughout the
		// whole method

        int result = 0;

        // Switch statement is used to determine which operation to perform
		// based on the user input

        switch (operation)
		{
			case '+':
				result = firstNumber + secondNumber;
				break;
			case '-':
                result = firstNumber - secondNumber;
                break; 
			case '*':
				result = firstNumber * secondNumber;
				break;
			case '/':
				result = firstNumber / secondNumber;
				break;
		}

        // Display the result, dollar sign is common way to format strings in C#
		// and allows for variable interpolation

        Console.WriteLine($"Result: {result}");


    }
	catch (Exception ex)
	{
        //ex is a variable that holds the exception object, which contains
		//information about the error that occurred

        Console.WriteLine($"An error occurred: {ex.Message}. Please enter a valid operation.");
        throw;
	}
}

// Call the CalcApp method to run the calculator application,
// must be outside
// of the method to avoid recursion and stack overflow errors
CalcApp();

