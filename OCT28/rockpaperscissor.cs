using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int HumanScore = 0;
            int ComputerScore = 0;
            Random random = new Random();

            Console.WriteLine("Welcome to Rock-Paper-Scissors!");

            while (true)
            {
                Console.Write("Choose (rock, paper, scissors): ");
                string HumanChoice = Console.ReadLine().ToLower();

                string[] choices = { "rock", "paper", "scissors" };
                
                int choice = random.Next(3);
                string computerChoice;

               
                if (choice == 0) computerChoice = "rock";
                else if (choice == 1) computerChoice = "paper";
                else computerChoice = "scissors";
                Console.WriteLine($"Computer chose: {computerChoice}");

                if (HumanChoice != "rock" && HumanChoice != "paper" && HumanChoice != "scissors")
                {
                    Console.WriteLine("Invalid choice, try again.");
                    continue;
                }

                if (HumanChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((HumanChoice == "rock" && computerChoice == "scissors") ||
                         (HumanChoice == "scissors" && computerChoice == "paper") ||
                         (HumanChoice == "paper" && computerChoice == "rock"))
                {
                    Console.WriteLine("You win this round!");
                    HumanScore++;
                }
                else
                {
                    Console.WriteLine("Computer wins this round!");
                    ComputerScore++;
                }

                Console.WriteLine($"Score - You: {HumanScore}, Computer: {ComputerScore}");
                if (HumanScore == 10)
                {
                    Console.WriteLine("Congratulations! You won!");
                }
                else
                {
                    Console.WriteLine("Computer wins! Try again.");
                }

            }
        }
    }
}
