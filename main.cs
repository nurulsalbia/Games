using System;
					
public class Program
{
	public static void Main()
	{
		PlayGame();
	}
	
	public static void PlayGame()
	{
		// Player1 chooses a sign
		Console.WriteLine("Type 1 for Rock, 2 For paper, 3 for scissors 4 for lizard and 5 for Spock ");
		int Player1 = Convert.ToInt32(Console.ReadLine());
		
		// Player2 chooses a sign
		Console.WriteLine("Type 1 for Rock, 2 For paper, 3 for scissors 4 for lizard and 5 for Spock ");
		int Player2 = Convert.ToInt32(Console.ReadLine());
		
		// AI chooses a sign
		//System.Random random = new System.Random();
		//int aiChoice = random.Next(1, 4);
		//Console.WriteLine("AI chooses: " + aiChoice);
		// Runs the Rules and decides who wins
		
		Rules(Player1, Player2);
		// Asks to play again
		Console.WriteLine("Do you want to play again? Y/N");
		PlayAgain(Console.ReadLine());
	}
	
	public static void Rules(int Player1, int Player2)
	{
		string p1 = "Player 1 wins!";
		string p2 = "Player 2  wins!";
		string d = "Draw!";
		
		// Player Wins
		if(Player1 == 1 && Player2 == 3)
			Console.WriteLine(p1);
		if(Player1 == 2 && Player2 == 1)
			Console.WriteLine(p1);
		if(Player1 == 2 && Player2 == 5)
			Console.WriteLine(p1);
		if(Player1 == 2 && Player2 == 3)
			Console.WriteLine(p1);
		if(Player1 == 3 && Player2 == 2)
			Console.WriteLine(p1);
		if(Player1 == 3 && Player2 == 4)
			Console.WriteLine(p1);
		if (Player1 == 4 && Player2 == 5)
		    Console.WriteLine(p1);
		if (Player1 == 5 && Player2 == 1)
		    Console.WriteLine(p1);
		if (Player1 == 4 && Player2 == 2)
		    Console.WriteLine(p1);
		if (Player1 == 5 && Player2 == 3)
		    Console.WriteLine(p1);
		    
		// Player2 Wins
		if(Player2 == 1 && Player1 == 3)
			Console.WriteLine(p2);
		if(Player2 == 2 && Player1 == 1)
			Console.WriteLine(p2);
		if(Player2 == 2 && Player1 == 5)
			Console.WriteLine(p2);
		if(Player2 == 2 && Player1 == 3)
			Console.WriteLine(p2);
		if(Player2 == 3 && Player1 == 2)
			Console.WriteLine(p2);
		if(Player2 == 3 && Player1 == 4)
			Console.WriteLine(p2);
		if (Player2 == 4 && Player1 == 5)
		    Console.WriteLine(p2);
		if (Player2 == 5 && Player1 == 1)
		    Console.WriteLine(p2);
		if (Player2 == 4 && Player1 == 2)
		    Console.WriteLine(p2);
		if (Player2 == 5 && Player1 == 3)
		    Console.WriteLine(p2);
			
		// Draws
		if(Player1 == 1 && Player2 == 1)
			Console.WriteLine(d);
		if(Player1 == 2 && Player2 == 2)
			Console.WriteLine(d);
		if(Player1 == 3 && Player2 == 3)
			Console.WriteLine(d);
		if(Player1 == 4 && Player2 == 4)
			Console.WriteLine(d);
		if(Player1 == 5 && Player2 == 5)
			Console.WriteLine(d);
	}
	
	public static void PlayAgain(string input)
	{
		input.ToLower();
		if(input == "y" || input == "yes")
			PlayGame();
		if(input == "n" || input == "no")
			Console.WriteLine("Thank you for playing!");	
		else if(input != "y" && input != "yes" && input != "n" && input != "no")
		{
			Console.WriteLine("Sorry I don't understand... Please try again");
			PlayAgain(Console.ReadLine());
		}
	}
}
