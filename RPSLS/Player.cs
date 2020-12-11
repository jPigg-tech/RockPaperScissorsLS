using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        // Memeber Variables (Has A)
        public string name;
        public int score;
        public List<Gesture> gesturesList;
        public Gesture chosenGesture;

        // Constructor (Spawner)
        public Player(string name)
        {
            this.name = name;
            score = 0;
            
            gesturesList = new List<Gesture>();


            Gesture rock = new Gesture("rock", "sciisors", "lizard");
            Gesture paper = new Gesture("paper", "rock", "spock");
            Gesture scissors = new Gesture("scissors", "paper", "lizard");
            Gesture lizard = new Gesture("lizard", "paper", "spock");
            Gesture spock = new Gesture("spock", "rock", "scissors");

            PopulateGestureList(rock);
            PopulateGestureList(paper);
            PopulateGestureList(scissors);
            PopulateGestureList(lizard);
            PopulateGestureList(spock);

        }

        // Member Methods (Can Do)
        public void PopulateGestureList(Gesture gesture)
        {
            gesturesList.Add(gesture);
        }
        public abstract string ChooseGesture();
    }
}
