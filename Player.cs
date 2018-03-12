using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackGame
{
    class Player
    {
        public List<Card> Hand { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public int KeepScore()
        {
            Score = 0;
            foreach (var card in Hand)
            {
                if (card.Played == false) {

               
              
                    if(card.Name == "Ace")
                    {

                        card.Played = true;
                        Console.WriteLine("Do you want Ace to equal 1 or 11?");
                        string playAns = Console.ReadLine();
                        if(playAns == "1")
                        {
                       
                            card.Value = 1;
                        }else if (playAns == "11")
                        {
                       
                            card.Value = 11;
                        }
                    
                        //int x = Convert.ToInt32(playAns);
                        //try
                        //{
                       
                        //}
                        //catch (Exception)
                        //{

                        //    throw;
                        //}
                    }
                }
                Score += card.Value;
            }
            return Score;
        }

        public Player()
        {
            Hand = new List<Card>();

        }

        //public static string playerPlay = Console.ReadLine().ToUpper();
        //public static bool Play(Dealer dealer, Player player, string playerPlay)

        //{

        //    if (playerPlay == "HIT")

        //    {
        //        Console.WriteLine("You Drew: ");
        //        player.Hand.Add(DealHand.DealCard());
        //        Console.WriteLine("Dealer Drew: ");
        //        dealer.MyHand.Add(DealHand.DealCard());

        //        player.KeepScore();
        //        dealer.KeepScore();


        //        Console.WriteLine("Your Score: " + player.Score);
        //        Console.WriteLine("Dealer Score: " + dealer.Score);

        //    }
        //    else if (playerPlay == "STAND")
        //    {
        //        if (player.Score <= 21 && player.Score > dealer.Score)
        //        {
        //            Console.WriteLine("You won! : " + player.Score + " to " + dealer.Score);
        //            //break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Dealer Won :(");
        //        }

        //    }
        // }

        //public string Move()
        //{
        //    string _play = Console.ReadLine().ToUpper();
        //    return _play;
        //}
        public void Play(Dealer dealer, Player player, string playerPlay)
        {
            if (playerPlay == "HIT")

            {
                Console.WriteLine("You Drew: ");
                player.Hand.Add(DealHand.DealCard());
                Console.WriteLine("Dealer Drew: ");
                dealer.MyHand.Add(DealHand.DealCard());

                player.KeepScore();
                dealer.KeepScore();


                Console.WriteLine("Your Score: " + player.Score);
                Console.WriteLine("Dealer Score: " + dealer.Score);

            }
            //else if (playerPlay == "STAND")
            //{
            //    if (player.Score <= 21 && player.Score > dealer.Score)
            //    {
            //        Console.WriteLine("You won! : " + player.Score + " to " + dealer.Score);
            //        //break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Dealer Won :(");
            //    }

            //}
        }
    }
}
