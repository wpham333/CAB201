using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Low_Level_Objects_Library;
using System.Threading.Tasks;

namespace Games_Logic_Library {
    public static class Two_Up_Game {
        private static Coin coin1;
        private static Coin coin2;
        private static int playerScore;
        private static int computerScore;

        // Must first create a void where the values of the computer and player is given and
        // coins given a value as well

        public static void SetUpGame() {
            coin1 = new Coin();
            coin2 = new Coin();
            playerScore = 0;
            computerScore = 0;
        }

        //Now a function must be created where we call the flip action from Coin.cs
        // Thus, making the coins flip and choosing either heads of tails

        public static void TossCoin() {
            coin1.Flip();
            coin2.Flip();
        }

        // We then must create a function that will read the outcome of the toss
        // Thus, if its both heads, tails or odd, it will then can be later called in other
        // functions

        public static string TossOutcome() {

            if (coin1.IsHeads() && coin2.IsHeads()) {  
                return "Heads";
            } 
            else if (coin1.IsHeads() && !coin2.IsHeads() 
                || !coin1.IsHeads() && coin2.IsHeads()) {
                return "Odd";
            }
            else if (!coin1.IsHeads() && !coin2.IsHeads()) {
                return "Tails";
            }
            return "";
        }

        // Giving the coin a boolean value, thus, allowing the addition of 1 to 
        // player and computer score much simpler

        public static bool IsHeads(int whichCoin) {
            if (whichCoin == 0) {
                return coin1.IsHeads();
            }else{
                return coin2.IsHeads();
            }
        }

        // We must then create a function that will add 1 to the player score
        // if toss outcome = both heads

        public static int GetPlayersScore() {
            if (TossOutcome() == "Heads") {
                return playerScore += 1;
            }else{
                //nothing
                return playerScore;
            }
        }

        // Then we must also create the counter part, allowing when both coins coming to tails
        // the computer score will increase by 1

        public static int GetComputersScore() {
            if (TossOutcome() == "Tails") {
                return computerScore += 1;
            }else{
                //nothing
                return computerScore;
            }
        }
    }
}
