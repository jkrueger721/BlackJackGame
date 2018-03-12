using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackGame
{
    class Dealer
    {
        public List<Card> MyHand { get; set; }
        public int Score { get; set; }

        public int KeepScore()
        {
            Score = 0;
            foreach (var card in MyHand)
            {
                Score += card.Value;
            }
            return Score;
        }

        public Dealer()
        {
            MyHand = new List<Card>();
        }

    }
}
