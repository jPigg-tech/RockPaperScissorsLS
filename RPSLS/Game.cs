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
        public List<Gesture> gesturesList;
        Player playerOne;
        Player playerTwo;
        Gesture gesture;


        // Constructor (Spawner)
        public Game()
        {

        }

        // Member Methods (Can Do)
        public void RunGame()
        {
            Welcome();
            ChooseGameMode();

            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                // Run single round of the game
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
            Console.WriteLine("Enter your name?");
            string playersName = Console.ReadLine();
            return playersName;
        }
        public void ChooseGameMode()
        {
            Console.WriteLine("Please choose game mode to play \n");
            string mode = Console.ReadLine();

            switch (mode)
            {
                case "Human vs Human":
                    playerOne = new Human(GetPlayersName());
                    playerTwo = new Human(GetPlayersName());
                    break;

                case "Human vs Computer":
                    playerOne = new Human(GetPlayersName());
                    playerTwo = new AI(GetPlayersName());
                    break;

                case "Computer vs Computer":
                    playerOne = new AI(GetPlayersName());
                    playerTwo = new AI(GetPlayersName());
                    break;

                default:
                    Console.WriteLine("Not a valid gmae mode");
                    break;
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
            if (playerOne.ChooseGesture() == playerTwo.ChooseGesture())
            {
                Console.WriteLine("The round is a tie.");
            }
            else if (playerOne.ChooseGesture() != playerTwo.ChooseGesture())
            {
                if (playerOne.chosenGesture.type == playerTwo.chosenGesture.beatsOne)
                {
                    Console.WriteLine(playerOne + "Wins this round!");
                }
                else if ((playerOne.chosenGesture.type == playerTwo.chosenGesture.beatsTwo))
                {
                    Console.WriteLine(playerOne + "Wins this round!");
                }              
            }
            else
            {
                Console.WriteLine(playerTwo + "Wins this round!");
            }
        }
    }
}
