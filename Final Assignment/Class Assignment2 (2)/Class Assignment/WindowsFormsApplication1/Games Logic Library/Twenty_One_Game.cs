using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Twenty_One_Game {
        private static CardPile cardPile;
        private static Hand[] hands = new Hand[2];
        private static int[] totalPoints;
        private static int[] numOfGamesWon;
        private static int numOfUserAcesWithValueOne;

        // Set up game, where both players can be given
        // and the value of the cards are read

        public static void SetUpGame() {
            Card pile = new Card();
            hands[0] = new Hand();
            hands[1] = new Hand();
            totalPoints = new int[2];
            numOfGamesWon = new int[2];
            numOfUserAcesWithValueOne = 0;
        }

        //A function where 2 cards are given to the player (If first cards is given to player, it
        // will then proceed to deal the house

        public static Card DealOneCardTo(int who) {
            CardPile cardPile = new CardPile(true);
            cardPile.Shuffle();
            Card card1 = new Card();
            Card card2 = new Card();
            if (who == 0) {
                card1 = cardPile.DealOneCard();
                hands[0].Add(card1);
                return card1;
            }else{
                card2 = cardPile.DealOneCard();
                hands[1].Add(card2);
                return card2;
            }
        }

        // A calculatehandtotal will then be created, where both cards will be read and given values
        // However, for Ace, it will give users an option to have their ace to have the value of 1 or 11

        public static int CalculateHandTotal(int who) {
            FaceValue face;
            FaceValue facetwo;
            int handTotal = 0;
            string face_one;
            string face_two;

            //an if statement with switch cases will allow the program to sort through all the numbers
            // and if a number is seen to be given, it will then add that number to total points

            if (who == 0) {
                foreach (Card cards in hands[0]) {
                    face = cards.GetFaceValue();
                    face_one = face.ToString();
                    switch (face_one) {
                        case "Ace":
                            if (numOfUserAcesWithValueOne != 0) {
                                totalPoints[0] += 1;
                                handTotal += 1;
                                break;
                            } else {
                                totalPoints[0] += 11;
                                handTotal += 11;
                                break;
                            }
                        case "Two":
                            totalPoints[0] += 2;
                            handTotal += 2;
                            break;
                        case "Three":
                            totalPoints[0] += 3;
                            handTotal += 3;
                            break;
                        case "Four":
                            totalPoints[0] += 4;
                            handTotal += 4;
                            break;
                        case "Five":
                            totalPoints[0] += 5;
                            handTotal += 5;
                            break;
                        case "Six":
                            totalPoints[0] += 6;
                            handTotal += 6;
                            break;
                        case "Seven":
                            totalPoints[0] += 7;
                            handTotal += 7;
                            break;
                        case "Eight":
                            totalPoints[0] += 8;
                            handTotal += 8;
                            break;
                        case "Nine":
                            totalPoints[0] += 9;
                            handTotal += 9;
                            break;
                        case "Ten":
                            totalPoints[0] += 10;
                            handTotal += 10;
                            break;
                        case "Jack":
                            totalPoints[0] += 10;
                            handTotal += 10;
                            break;
                        case "Queen":
                            totalPoints[0] += 10;
                            handTotal += 10;
                            break;
                        case "King":
                            totalPoints[0] += 10;
                            handTotal += 10;
                            break;
                    }
                }
            } else {
                foreach (Card cards in hands[1]) {
                    facetwo = cards.GetFaceValue();
                    face_two = facetwo.ToString();
                    switch (face_two) {
                        case "Ace":
                            totalPoints[1] += 11;
                            handTotal += 11;
                            break; 
                        case "Two":
                            totalPoints[1] += 2;
                            handTotal += 2;
                            break;
                        case "Three":
                            totalPoints[1] += 3;
                            handTotal += 3;
                            break;
                        case "Four":
                            totalPoints[1] += 4;
                            handTotal += 4;
                            break;
                        case "Five":
                            totalPoints[1] += 5;
                            handTotal += 5;
                            break;
                        case "Six":
                            totalPoints[1] += 6;
                            handTotal += 6;
                            break;
                        case "Seven":
                            totalPoints[1] += 7;
                            handTotal += 7;
                            break;
                        case "Eight":
                            totalPoints[1] += 8;
                            handTotal += 8;
                            break;
                        case "Nine":
                            totalPoints[1] += 9;
                            handTotal += 9;
                            break;
                        case "Ten":
                            totalPoints[1] += 10;
                            handTotal += 10;
                            break;
                        case "Jack":
                            totalPoints[1] += 10;
                            handTotal += 10;
                            break;
                        case "Queen":
                            totalPoints[1] += 10;
                            handTotal += 10;
                            break;
                        case "King":
                            totalPoints[1] += 10;
                            handTotal += 10;
                            break;
                    }
                }
            }
            return handTotal;
        }

        // A randomiser for the cards, thus, knowing cards will be different (when dealing)

        public static void PlayForDeal() {
            totalPoints[1] = 0;
            CardPile cardPile = new CardPile(true);
            cardPile.Shuffle();
            hands[1].Add(cardPile.DealOneCard());
        }

        // Function where the hand will recieve 2 cards

        public static Hand GetHand(int who) {
            if (who == 0) {
                return hands[0] = hands.ElementAt(0);
            } else {
                return hands[1] = hands.ElementAt(1);
            }
        }

        // We then must create a function that will be called later on which has the value of both cards

        public static int GetTotalPoints(int who) {
            return totalPoints[who];
        }


        //After setting up the game and cards being dealt, we must then create a getnumofgamesown to then
        //award points to either player or house depending on who has won.

        public static int GetNumOfGamesWon(int who) {
            if (who == 0) {
                if (totalPoints[0] > totalPoints[1]) {
                    return numOfGamesWon[0] += 1;
                }else {
                    return numOfGamesWon[1] += 1;
                }
            } else {
                if (totalPoints[1] > totalPoints[0]) {
                    return numOfGamesWon[1] += 1;
                }else {
                    return numOfGamesWon[0] += 1;
                }
            }
        }



        public static int GetNumOfUserAcesWithValueOne() {
            return numOfUserAcesWithValueOne;
        }



        public static void IncrementNumOfUserAcesWithValueOne() {
            numOfUserAcesWithValueOne += 1;
        }

        public static void ResetTotals() {
            totalPoints[0] = 0;
        }
    }
}
