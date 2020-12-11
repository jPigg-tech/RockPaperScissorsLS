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

        // Constructor (Spawner)
        public Game(Player playerOne, Player playerTwo, Player winner)
        {
            this.playerOne = new Player(userInput);
            this.playerTwo = new Player(userInput);
        }

        // Member Methods (Can Do)
        public string GetPlayerOnesName()
        {
            Console.WriteLine("What is your name?");
            Console.ReadLine(string userInput);
        }
    }
}
