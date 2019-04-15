using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace Low_Level_Objects_Library {
    public class Hand : IEnumerable {

        private List<Card> hand;

        public Hand() {
            hand = new List<Card>();
        }

        public Hand(List<Card> cards) {
            // Don't know if needed....
            //hand = new List<Card>();
            hand = cards;
        }

        public int GetCount() {
            return hand.Count();
        }

        public Card GetCard(int index) {
            return hand.ElementAt(index);
        }

        public void Add(Card card) {
            hand.Add(card);
        }

        public bool Contains(Card card) {
            return hand.Contains(card);
        }

        public bool Remove(Card card) {
            return hand.Remove(card);
        }

        public void RemoveAt(int index) {
            hand.RemoveAt(index);
        }

        public void Sort() {
            hand.Sort();
        }

        public IEnumerator GetEnumerator() {
            return hand.GetEnumerator();
        }
    }

}

