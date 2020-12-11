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
        public Player playerOne;
        public Player playerTwo;
        public Player winner;
        public List<Gesture> gesturesList;
        public List<Player> playersList;

        // Constructor (Spawner)
        public Game(Player playerOne, Player playerTwo, Player winner)
        {
            this.playerOne = new Player(playerOne);
            this.playerTwo = new Player(userInput);
        }

        // Member Methods (Can Do)
        public string GetPlayersName()
        {
            Console.WriteLine("What is your name?");
            string playersName = Console.ReadLine();
            return playersName;
        }
        public int ChooseOpponent(Opponents opponents)
        {
            Console.WriteLine("Choose your opponent:");
            for (int i = 0; i < opponents.playerList.Count; i++)
            {
                Console.WriteLine("Press " + i + " for " + opponents.playerList[i].name);
            }
            string input = Console.ReadLine();
            return Int32.Parse(input);
        }
        
    }
}
