namespace RPSGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dialog.Intro();

                Player player1 = new Player();
                player1.Hardmode = false;
           

            
            Game.Round(player1);

                        
            

        }
    }
}
