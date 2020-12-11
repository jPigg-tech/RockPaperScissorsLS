using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gesture
    {
        // Member Variables

        public string type; // rock
        public string beatsOne; // scissors 
        public string beatsTwo; // lizard

        // constructor
        public Gesture(string type, string beatsOne, string beatsTwo)
        {
            this.type = type;
            this.beatsOne = beatsOne;
            this.beatsTwo = beatsTwo;
        }

        // Member Methods 
    }
}
