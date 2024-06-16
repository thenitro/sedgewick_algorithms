using System;
using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_35_BridgeDeck
    {
        private const int AmountOfCardsPerHand = 13;
        public RandomQueue<Card> Deck { get; private set; }
        
        public E_1_3_35_BridgeDeck()
        {
            Deck = new RandomQueue<Card>();
            
            foreach (var suite in Enumerate<CardSuit>())
            {
                foreach (var rank in Enumerate<CardRank>())
                {
                    Deck.Enqueue(new Card(rank, suite));
                }
            }
        }

        public List<Card> DealHand()
        {
            var result = new List<Card>();
            var i = AmountOfCardsPerHand;

            while (i > 0)
            {
                result.Add(Deck.Dequeue());
                i--;
            }

            return result;
        }

        private T[] Enumerate<T>() where T : Enum => (T[])Enum.GetValues(typeof(T));
    }

    public class Card
    {
        public CardRank Rank { get; }
        public CardSuit Suit { get; }

        public Card(CardRank rank, CardSuit suit)
        {
            Rank = rank;
            Suit = suit;
        }
    }

    public enum CardRank
    {
        Two = 1,
        Three = 2,
        Four = 3,
        Five = 4,
        Six = 5,
        Seven = 6,
        Eight = 7,
        Nine = 8,
        Ten = 9,
        Jack = 10,
        Queen = 11,
        King = 12,
        Ace = 13,
    }

    public enum CardSuit
    {
        Diamonds = 1,
        Hearts = 2,
        Clubs = 3,
        Spades = 4,
    }
}