using System;

namespace testingrockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable for player input
            string PlayerInput = "";
            //variable for player choice
            string PlayerChoice = "";
            //compyter choice variabe
            string ComputerChoice = "";
            //variable for player quitting game
            string Quit = "";

            while (Quit != "quit")
            {

                //ask for player choice and store it
                Console.WriteLine("Rock, Paper, or Scissors?");
                PlayerInput = Console.ReadLine();
                PlayerInput = PlayerInput.ToLower();
                if (PlayerInput == "rock")
                {
                    PlayerChoice = "rock";
                }
                else if (PlayerInput == "scissors")
                {
                    PlayerChoice = "scissors";
                }
                else
                {
                    PlayerChoice = "paper";
                }

                //generate random number for computer choice and store it as such
                Random r = new Random();
                int rInt = r.Next(3);
                if (rInt == 0)
                {
                    ComputerChoice = "rock";
                }
                else if (rInt == 1)
                {
                    ComputerChoice = "scissors";
                }
                else
                {
                    ComputerChoice = "paper";
                }

                //compare player and computer answers
                if (PlayerChoice == ComputerChoice)
                {
                    Console.WriteLine("Tie!\n" + "Player: " + PlayerChoice + "\n" + "Computer: " + ComputerChoice);
                }
                else if (PlayerChoice == "rock" & ComputerChoice == "paper")
                {
                    Console.WriteLine("Computer Wins!\n" + "Player: " + PlayerChoice + "\n" + "Computer: " + ComputerChoice);
                }
                else if (PlayerChoice == "rock" & ComputerChoice == "scissors")
                {
                    Console.WriteLine("Player Wins!\n" + "Player: " + PlayerChoice + "\n" + "Computer: " + ComputerChoice);
                }
                else if (PlayerChoice == "paper" & ComputerChoice == "scissors")
                {
                    Console.WriteLine("Computer Wins!\n" + "Player: " + PlayerChoice + "\n" + "Computer: " + ComputerChoice);
                }
                else if (PlayerChoice == "paper" & ComputerChoice == "rock")
                {
                    Console.WriteLine("Player Wins!\n" + "Player: " + PlayerChoice + "\n" + "Computer: " + ComputerChoice);
                }
                else if (PlayerChoice == "scissors" & ComputerChoice == "rock")
                {
                    Console.WriteLine("Computer Wins!\n" + "Player: " + PlayerChoice + "\n" + "Computer: " + ComputerChoice);
                }
                else if (PlayerChoice == "scissors" & ComputerChoice == "paper")
                {
                    Console.WriteLine("Player Wins!\n" + "Player: " + PlayerChoice + "\n" + "Computer: " + ComputerChoice);
                }

                //End the game
                Console.WriteLine("End! Type \"quit\" to exit\nPress any key to continue...");
                Quit = Console.ReadLine();
                Quit = Quit.ToLower();
            }
        }
    }
}


/*How on earth is this project going to work? Like, *fuck*.
 * 
 * Okay. Problem solving time.
 * First:  Ask the player for their choice, Rock Paper or Scissors
 * Second: store their choice as one of the three
 * Third:  Generate a random number for computer, picks between the three options
 * fourth: compare computer choice to player choice
 * fifth: decide winner
 * */
