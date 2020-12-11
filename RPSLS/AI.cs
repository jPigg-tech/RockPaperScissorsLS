using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI: Player
    {
        // Memeber Variables (Has A)


        // Constructor (Spawner)
        public AI(string name) : base(name)
        {
            
        }

        // Member Methods (Can Do)
        public override string ChooseGesture()
        {
            var rand = new Random();
            int gesture = rand.Next(gesturesList.Count);
            // Console.WriteLine(gesturesList[gesture]);
            string input = gesture.ToString();
            return input;
        }        
    }
}
