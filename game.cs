using System;
using System.Threading;

namespace sfghjk
{		
	
	class Program
	{
		public static void Main(string[] args)
		{
			
			Thread.Sleep(1000);
				Console.WriteLine("Welcome to Rock Paper Scissor game :)");
				Thread.Sleep(1000);
				Console.Clear();
				Thread.Sleep(1000);
				Console.WriteLine("Your game is loading");
				Thread.Sleep(1000);
				
				for (int i=0;i<=19;i++) {
					Console.Write("|");
					Thread.Sleep(0300);
				}
				Thread.Sleep(1000);
				Console.Clear();
			
			
			
			int playerWins = 0;
			int computerWins = 0;
			int draws = 0;
			
			do
			{
				Random random = new Random();
				int ai_choose = random.Next(1,4); 
				
				string[] computerChoices = new string[3];
				
				computerChoices[0] = "Paper";
				computerChoices[1] = "Rock";
				computerChoices[2] = "Scissors";
				
				string aiChoice = computerChoices[ai_choose - 1]; 
				
				Console.WriteLine("Choose: 1 - Paper, 2 - Rock, 3 - Scissors");
				int player_choose = int.Parse(Console.ReadLine());
				
				string playerChoice = ""; 
				
				
				switch(player_choose)
				{
					case 1:
						playerChoice = "Paper";
						break;
					case 2:
						playerChoice = "Rock";
						break;
					case 3:
						playerChoice = "Scissors";
						break;
					default:
						Console.WriteLine("Invalid choice! Please choose a number between 1 and 3.");
						return;
				}
				
				Console.WriteLine("You chose: {0}", playerChoice);
				Console.WriteLine("Computer chose: {0}", aiChoice);
				
				
				if (playerChoice == aiChoice)
				{
					Console.WriteLine("It's a draw!");
					draws++;
				}
				else if ((playerChoice == "Rock" && aiChoice == "Scissors") || 
				         (playerChoice == "Paper" && aiChoice == "Rock") || 
				         (playerChoice == "Scissors" && aiChoice == "Paper"))
				{
					Console.WriteLine("You win!");
					playerWins++;
				}
				else
				{
					Console.WriteLine("Computer wins!");
					computerWins++;
				}
				
				Console.WriteLine("\nWins: Player - {0}, Computer - {1}, Ties - {2}\n", playerWins, computerWins, draws);
				
				Console.WriteLine("Do you want to continue? (yes/no)");
				string continueChoice = Console.ReadLine().ToLower();
				
				if (continueChoice != "yes")
				{
					Console.Clear();
					Console.WriteLine("Final Score:\nPlayer Wins: {0}\nComputer Wins: {1}\nDraws: {2}", playerWins, computerWins, draws);
					Thread.Sleep(5000);
					Environment.Exit(1);
					break;
				}
				
				Console.Clear();
				
			} while (true);
			
			Console.ReadKey(true);
		}
	}
}
