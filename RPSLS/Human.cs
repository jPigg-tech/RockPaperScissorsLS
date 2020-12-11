using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human: Player
    {
        // Memeber Variables (Has A)


        // Constructor (Spawner)
        public Human(string name, string type)
        {
            this.name = name;
            this.type = type;
            
        }

        // Member Methods (Can Do)
        public override void ChooseGesture()
        {
            Console.WriteLine("Choose your gesture: ");
            for (int i = 0; i < gesturesList.Count; i++)
            {
                Console.WriteLine("Press " + i + " for " + gesturesList[i].type);
            }
            // string input = Console.ReadLine();
        }
    }
}
