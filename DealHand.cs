using System;
using System.Collections.Generic;
using System.Text;


namespace BlackJackGame
{
    class DealHand


    {
       
       
        static Deck deck = new Deck();
        static Random rnd = new Random();
       


        public static Card DealCard( )
        {
          
            int r = rnd.Next(deck.Cards.Count - 1);
            Console.WriteLine(deck.Cards[r].Name + " of " + deck.Cards[r].Suite);
            Card card = deck.Cards[r];
            deck.Cards.Remove(deck.Cards[r]);
            return card;

        }
       public static bool CheckIfGameOver(Dealer dealer, Player player, string playerPlay)
        {

            if (dealer.Score == 21)
            {
                Console.WriteLine("Dealer Gets BlackJAck");
                return true;
            }
            else if (dealer.Score > 21)
            {
                Console.WriteLine("Dealer Bust!");
                return true;
            }
            else if (player.Score == 21)
            {
                Console.WriteLine("Player Gets BlackJAck");
                return true;
            }
            else if (player.Score > 21)
            {
                Console.WriteLine("Player Bust!");
                return true;
            }else if (playerPlay == "STAND")
            {

                if (player.Score <= 21 && player.Score > dealer.Score)
                {
                    Console.WriteLine("You won! : " + player.Score + " to " + dealer.Score);
                    //break;
                }
                else
                {
                    //Console.WriteLine("Final Score! Player: " + player.Score + " Dealer: " + dealer.Score);
                    Console.WriteLine("Dealer Won :(");
                }
                // calc total scores
               
                return true;
            }
            else
            {
               return false;
            }
        }
      
    }
}
