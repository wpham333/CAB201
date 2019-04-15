using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Low_Level_Objects_Library;
using System.Threading.Tasks;

namespace Games_Logic_Library {
    public static class Snake_Eyes_Game {

        private static int rollTotal;
        private static int playerTotal;
        private static int houseTotal;
        private static int possiblePoint;
        private static Die[] dice = new Die[2];
        private static bool first;
        private static bool again;


        //Must first create a method to set up the game, where all points that can be given start with 0 , rather than a value

        public static void SetUpGame() {
            rollTotal = 0;
            playerTotal = 0;
            houseTotal = 0;
            possiblePoint = 0;
            dice[0] = new Die();
            dice[1] = new Die();
        }

        // Check whether it is a 2,7,11,3,12 on the first roll = instant win

        public static bool FirstRoll() {
            first = false;

            dice[0].RollDie();
            dice[1].RollDie();

            

            // Creating a switch function that will allow the function to proceed and not
            // add any points to the scores, due to teh fact that the numbers will proceed
            // with a rollAgain
            switch (rollTotal) {
                
                case 2:
                    return first = true;
                case 3:
                    return first = true;
                case 7:
                    return first = true;
                case 11:
                    return first = true;
                case 12:
                    return first = true;
                case 4:
                    GetPossiblePoints();
                    return first = false;
                case 5:
                    GetPossiblePoints();
                    return first = false;
                case 6:
                    GetPossiblePoints();
                    return first = false;
                case 8:
                    GetPossiblePoints();
                    return first = false;
                case 9:
                    GetPossiblePoints();
                    return first = false;
                case 10:
                    GetPossiblePoints();
                    return first = false;
            }
            GetPlayerPoints();
            GetHousePoints();

            return first;
            //return rollAgain;
        }

        // Must now create anotherroll function, where on the first roll, instant win numbers werent rolled
        // the function will allow the player to continue to roll

        public static bool AnotherRoll() {
            again = true;
            dice[0].RollDie();
            dice[1].RollDie();

            if(possiblePoint == rollTotal) {
                again = false;
                GetPlayerPoints();
                return again;

            } else if(rollTotal == 7) {
                again = false;
                GetHousePoints();
                return again;
                              
            } else {
                return again = true;
            }
        }

        // A method that reads the face value of the die, which will be called in other functions later on

        public static int GetDiceFacevalue(int whichDie) {
            int faceValue;
            faceValue = dice[whichDie].GetFaceValue();
            return faceValue;
        }

        // Now a getplayerpoints method must be created, that will give points to player depending
        // on the number that were rolled (E.g 7,11, go to player)

        public static int GetPlayerPoints() {

            if (first == true && GetRollTotal() == 2) {
                return playerTotal += 2;
            } else if (first == true && (GetRollTotal() == 7 || GetRollTotal() == 11)) {
                return playerTotal += 1;
            } else if (again == true && possiblePoint == rollTotal) {
                return playerTotal += possiblePoint;
            } else {
                return playerTotal;
            }
        }

        // Same method must be created for house, where if the die roll a 12 or 3, the house recieves 1 point
        // if 7 is rolled the house gets 2 points

        public static int GetHousePoints() {

            if(first == true && (GetRollTotal() == 3 || GetRollTotal() == 12)) {
                return houseTotal += 1;
            } else if(again == false && rollTotal == 7) {
                return houseTotal += 2;
            } else {
                return houseTotal;
            }
        }

        // Now a getpossible points must be created, where the player (if rolls a 4,5,6,8,9,10)
        // the number will be saved, and the player must roll that exact number again to recieve
        // points according to the amount rolled


        public static int GetPossiblePoints() {

            switch (rollTotal) {
                case 4:
                    return possiblePoint = 4;
                case 5:
                    return possiblePoint = 5;
                case 6:
                    return possiblePoint = 6;
                case 8:
                    return possiblePoint = 8;
                case 9:
                    return possiblePoint = 9;
                case 10:
                    return possiblePoint = 10;
            }
            return possiblePoint;

        }
            

        // A get roll total function must be created that allows to calculate the face values
        // on both die

        public static int GetRollTotal() {
            return rollTotal = GetDiceFacevalue(0) + GetDiceFacevalue(1);
        }


        // Win, lost or no result.
        public static string GetRollOutcome() {
            if (first == true && (rollTotal == 2 || rollTotal == 7 || rollTotal == 11)) {
                return "Won";
            } else if (first == true && (rollTotal == 3 || rollTotal == 12)) {
                return "Lose";
            }
            return "Nothing";
        }
    }
}
