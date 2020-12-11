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
        public Player winner;
        public List<Gesture> gesturesList;
        public List<Player> playerList;
        public Opponents opponents;
        int playerOneScore;
        int playerTwoScore;


        // Constructor (Spawner)
        public Game()
        {           

        }

        // Member Methods (Can Do)
        public void RunGame()
        {
            string playerOne = GetPlayersName();
            string playerTwo = ChooseOpponent();

            while(playerOneScore < 2 && playerTwoScore < 2)
            {
                // Run  single round of the game
            }

            DisplayWinner();
        }

        public string GetPlayersName()
        {
            Console.WriteLine("What is your name?");
            string playersName = Console.ReadLine();
            return playersName;
        }
        public string ChooseOpponent()
        {
            Console.WriteLine("Choose your opponent:");
            for (int i = 0; i < opponents.playerList.Count; i++)
            {
                Console.WriteLine("Press " + i + " for " + opponents.playerList[i].type);
            }
            string input = Console.ReadLine();
            return input;
        }
        public void DisplayWinner()
        {
            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine("Player One has won the game!");
            }

            else
            {
                Console.WriteLine("Player Two has won the game!");
            }
        }
    }
}
