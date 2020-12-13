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
        Random rand;

        // Constructor (Spawner)
        public AI(string name, Random rand) : base(name)
        {
            this.rand = rand;
        }

        // Member Methods (Can Do)
        public override void ChooseGesture()
        {     
            int gesture = rand.Next(gesturesList.Count);

            chosenGesture = gesturesList[gesture];
        }        
    }
}
