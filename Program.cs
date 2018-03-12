using System;


namespace BlackJackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var player = new Player();
            var dealer = new Dealer();

           
            bool gameOver = false;
            Console.WriteLine("Welcome to Black Jack card game. What is your name: ");
            player.Name = Console.ReadLine();
            Console.WriteLine("Hi " + player.Name);





            Random rnd = new Random();
            Random rnd2 = new Random();

            Console.WriteLine("Your Hand: ");
            player.Hand.Add(DealHand.DealCard());
            player.Hand.Add(DealHand.DealCard());
            Console.WriteLine("Dealer Hand: ");
            dealer.MyHand.Add(DealHand.DealCard());
            dealer.MyHand.Add(DealHand.DealCard());

            //while (dealer.Score > 17)
            //{
            //    dealer.MyHand.Add(DealHand.DealCard());
            //    continue;
            //}

            player.KeepScore();
            dealer.KeepScore();
            Console.WriteLine("your Score: " + player.Score);
            Console.WriteLine("Dealer Score: " + dealer.Score);
            gameOver = DealHand.CheckIfGameOver(dealer, player, "");
            //if (gameOver == true)
            //{
            //    break;
            //}

            while (gameOver == false)
            {
               
         
            Console.WriteLine("Would you like to HIT or STAND?");
            string playerPlay = Console.ReadLine().ToUpper();
            gameOver = DealHand.CheckIfGameOver(dealer, player, playerPlay);
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
                    gameOver = DealHand.CheckIfGameOver(dealer, player, playerPlay);
                }
              


            }

                     
            

            // keep program open
            Console.ReadLine();







        }
    }
}