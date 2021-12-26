using System;
using System.Collections.Generic;

namespace poker
{
    public class Player
    {
        public List<Card> deck;
        public int money;


        public Player(int money)
        {
            this.money = money;
        }

        public Player(List<Card> deck, int money)
        {
            this.deck = deck;
            this.money = money;
        }
    }
}
