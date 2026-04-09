using System;
using System.Globalization;

public class Program
{
	public static string UserInput;
	public static int UserNum;
	public static void Main()
	{
		Console.WriteLine("Pick a number 1 through 10");
		//string? userInput = Console.ReadLine();
		UserInput = Console.ReadLine();
		//if (int.TryParse(userInput, out int UserNum));
		int UserNum = int.Parse(UserInput);
				//countdown T-10 seconds
		Console.WriteLine($"T-{UserInput} seconds until ignition");
		Console.WriteLine(Countdown(UserInput));

		Console.WriteLine("Blast off!");
	}

	public static int Countdown()
	{
		//int UserNum = int.Parse(userInput);
		if(Usernum <= 0)
		{
			return 0;
		}
		else
		{
			//if (int.TryParse(Program.UserInput, out int UserNum));

			//the return and multiply the number by the method is not
			// essential, this is just a use case 
			//  return number * FactorialSolver(number - 1);
		//whats needed here is subtraction only
		return Countdown(UserNum - 1);
		}
	}
}//end of whole public class program