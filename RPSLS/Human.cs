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
        public Human(string name):base(name)
        {
                       
        }

        // Member Methods (Can Do)
        public override void ChooseGesture()
        {
            bool checkInput = true;
            while (checkInput)
            {
                    Console.WriteLine("Choose your gesture: ");
                for (int i = 0; i < gesturesList.Count; i++)
                {
                    Console.WriteLine("Press " + i + " for " + gesturesList[i].type);
                }
                    string input = Console.ReadLine();
                    
                    switch (input)
                    {
                        case "1":
                        case "rock":
                        chosenGesture = gesturesList[0];
                        checkInput = false;
                        break;

                        case "2":
                        case "paper":
                        chosenGesture = gesturesList[1];
                        checkInput = false;
                        break;

                        case "3":
                        case "scissors":
                        chosenGesture = gesturesList[2];
                        checkInput = false;
                        break;

                        case "4":
                        case "lizard":
                        chosenGesture = gesturesList[3];
                        checkInput = false;
                        break;

                        case "5":
                        case "spock":
                        chosenGesture = gesturesList[4];
                        checkInput = false;
                        break;

                        default:
                        Console.WriteLine("Not a valid gesture choice. Try again!");
                        break;
                    }
            }           
        }
    }
}
