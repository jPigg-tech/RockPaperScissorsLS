﻿using System;
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
        public string type;
        public int score;
        public List<Gesture> gesturesList;

        // Constructor (Spawner)
        public Player(string name, string type)
        {
            this.name = name;
            this.type = type;
            score = 0;
            gesturesList = new List<Gesture>();

            Gesture rock = new Gesture("rock");
            Gesture paper = new Gesture("paper");
            Gesture scissors = new Gesture("scissors");
            Gesture lizard = new Gesture("lizard");
            Gesture spock = new Gesture("spock");

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
        public abstract void ChooseGesture();
    }
}
