using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Opponents
    {
        public List<Player> playerList;

        public Opponents()
        {
            playerList = new List<Player>();

            Human human = new Human("playerOne", "Human");
            AI computer = new AI("iDontLose", "Computer");

            playerList.Add(human);
            playerList.Add(computer);
              
        }
    }
}
 