using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Crazy_Eight_Game {

        private static CardPile cardPile;
        private static Hand[] hands = new Hand[3];

        public static void SetUpGame() {
            cardPile = new CardPile(true);
            cardPile.Shuffle();
            hands[0] = new Hand();
            hands[1] = new Hand();
            hands[2] = new Hand();
        }

        public static Card DealOneCardTo(int who) {
            Card card1 = new Card();
            Card card2 = new Card();
            if (who == 0) {
                card1 = cardPile.DealOneCard();
                hands[0].Add(card1);
                return card1;
            } else {
                card2 = cardPile.DealOneCard();
                hands[1].Add(card2);
                return card2;
            }
        }

        public static Hand GetHand(int who) {
            if (who == 0) {
                return hands[0] = hands.ElementAt(0);
            } else {
                return hands[1] = hands.ElementAt(1);
            }
        }

        public static void Sort() {
            hands[0].Sort();
        }

        public static Card DealOneCardToMiddle() {
            Card card3;
            card3 = cardPile.DealOneCard();
            hands[2].Add(card3);
            return card3;
        }

        public static Card Check(Card clickedCard) {
            int counter = hands[2].GetCount();
            if (clickedCard.GetSuit() == hands[2].GetCard(counter - 1).GetSuit()
                || clickedCard.GetFaceValue() == hands[2].GetCard(counter - 1).GetFaceValue()) {
                hands[0].Remove(clickedCard);
                hands[2].Add(clickedCard);
                return clickedCard;
            }
            else if (clickedCard.GetFaceValue() == FaceValue.Eight) {
                return clickedCard;
            } else {
                return hands[2].GetCard(counter - 1);
            }
        }

        //public static Card CheckForComputer()

        public static void Add() {
            hands[0].Add(cardPile.DealOneCard());
        }

        public static Card SendToTheMiddle(Card clickedCard) {
            hands[0].Remove(clickedCard);
            hands[2].Add(clickedCard);
            return clickedCard;
        }

    }
}
