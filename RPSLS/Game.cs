﻿using System;
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
        public Opponents opponents;
        Player playerOne;
        Player playerTwo;


        // Constructor (Spawner)
        public Game()
        {

        }

        // Member Methods (Can Do)
        public void RunGame()
        {
            string playerOne = GetPlayersName();
            string playerTwo = ChooseOpponent();

            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                // Run single round of the game
            }

            DisplayWinner();
        }

        public string GetPlayersName()
        {
            Console.WriteLine("What is your name?");
            string playersName = Console.ReadLine();
            return playersName;
        }
        public void ChooseOpponent()
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
                Console.WriteLine("Player One has won the game!");
            }
            else
            {
                Console.WriteLine("Player Two has won the game!");
            }
        }
        public void RunSingleRound()
        {

        }
    }
}
