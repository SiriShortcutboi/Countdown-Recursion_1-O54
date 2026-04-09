using System;

public class Program
{
	public static void Main()
	{
		int userNum = 0;

		while (true)
		{
			Console.WriteLine("Pick a number 1 through 10");
			string? userInput = Console.ReadLine(); //here we catch the null
			bool isValid = int.TryParse(userInput, out userNum);
			bool isNegative = userNum < 0;

			if (!isValid || isNegative)
			{// here we tell them to type soemthing thatst not null
				Console.WriteLine("Please enter a whole number that is more than 0");
				continue;
			}

			break;
		}
		Console.Clear();
		Console.WriteLine($"T-{userNum} seconds until ignition");
		Countdown(userNum);
		Console.WriteLine("Blast off!");
	}

	public static void Countdown(int number)
	{
		Console.WriteLine(number);

		if (number == 0)
		{
			return;
		}

		Countdown(number - 1);
	}
}