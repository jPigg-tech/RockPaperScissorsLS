using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        // Memeber Variables (Has A)
        Player playerOne;
        Player playerTwo;
        Random rand;

        // Constructor (Spawner)
        public Game()
        {
            rand = new Random();
        }

        // Member Methods (Can Do)
        public void RunGame()
        {
            Welcome();
            ChooseGameMode();

            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                // Run single round of the game
                RunSingleRound();
            }

            DisplayWinner();
        }
        public void Welcome()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard SPOCK!");
            Console.WriteLine("The fate of the deul is in your hands! Literally!");
            Console.ReadLine();
        }

        public string GetPlayersName()
        {
            Console.WriteLine("Enter the players name.");
            string playersName = Console.ReadLine();
            return playersName;
        }
        public void ChooseGameMode()
        {
            bool checkInput = true;
            while (checkInput)
            {
                Console.WriteLine("Please choose game mode to play \n");
                Console.WriteLine("Enter '1' for Human vs Human.");
                Console.WriteLine("Enter '2' Human vs Computer.");
                Console.WriteLine("Enter '3' Computer vs Computer. \n");
                string mode = Console.ReadLine();

                switch (mode)
                {
                    case "1":
                    case "Human vs Human":
                    playerOne = new Human(GetPlayersName());
                    playerTwo = new Human(GetPlayersName());
                    checkInput = false;
                    break;

                    case "2":
                    case "Human vs Computer":
                    playerOne = new Human(GetPlayersName());
                    playerTwo = new AI(GetPlayersName(), rand);
                    checkInput = false;
                    break;

                    case "3":
                    case "Computer vs Computer":
                    playerOne = new AI(GetPlayersName(), rand);
                    playerTwo = new AI(GetPlayersName(), rand);
                    checkInput = false;
                    break;

                    default:
                    Console.WriteLine("Not a valid game mode");
                    break;
                }

            }
        }
        public void DisplayWinner()
        {
            if (playerOne.score > playerTwo.score)
            {
                Console.WriteLine(playerOne.name + " has won the game!");
            }
            else
            {
                Console.WriteLine(playerTwo.name + " has won the game!");
            }
        }
        public void RunSingleRound()
        {
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();

            if (playerOne.chosenGesture.type == playerTwo.chosenGesture.type)
            {
                Console.WriteLine(playerOne.name + " chose " + playerOne.chosenGesture.type + ".");
                Console.WriteLine(playerTwo.name + " chose " + playerTwo.chosenGesture.type + ". \n");
                Console.WriteLine("The round is a tie. \n");
            }
            else 
            {               
                if (playerOne.chosenGesture.beatsOne == playerTwo.chosenGesture.type)
                {
                    Console.WriteLine(playerOne.name + " chose " + playerOne.chosenGesture.type + ".");
                    Console.WriteLine(playerTwo.name + " chose " + playerTwo.chosenGesture.type + ". \n");
                    Console.WriteLine(playerOne.name + " Wins this round! \n");
                    playerOne.score++;
                    return;
                }
                else if (playerOne.chosenGesture.beatsTwo == playerTwo.chosenGesture.type)
                {
                    Console.WriteLine(playerOne.name + " chose " + playerOne.chosenGesture.type + ".");
                    Console.WriteLine(playerTwo.name + " chose " + playerTwo.chosenGesture.type + ". \n");
                    Console.WriteLine(playerOne.name + " Wins this round! \n");
                    playerOne.score++;
                    return;
                }
                Console.WriteLine(playerOne.name + " chose " + playerOne.chosenGesture.type + ".");
                Console.WriteLine(playerTwo.name + " chose " + playerTwo.chosenGesture.type + ". \n");
                Console.WriteLine(playerTwo.name + " Wins this round! \n");
                playerTwo.score++;                
            }
           
        }
    }
}
