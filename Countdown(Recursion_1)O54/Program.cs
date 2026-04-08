using System;
using System.Globalization;
//using System.Async;

public class Program
{
	 static int UserNum;
	public static void Main()
	{
		Console.WriteLine("Pick a number 1 through 10");
		string userInput = Console.ReadLine();
		//if (int.TryParse(System.Console.ReadLine(), out int UserNum));
		{
		}
				//countdown T-10 seconds
		Console.WriteLine($"T-{userInput} seconds until ignition");
			
		Console.WriteLine(Countdown(5)); // could i figure out how to make it run all in one go on line 22?
		//should only write with success
		if (UserNum == 0)
		{
			Console.WriteLine("Blast off!");
		} 
	}

	static int Countdown(int UserNum)
	{
		//Console.WriteLine(UserNum);
		if(UserNum == 0)
		{
			return 0;
		}
		else
		{
			Console.WriteLine(UserNum);
			return UserNum * Countdown(UserNum - 1);
		}
		
		
		

	}


}