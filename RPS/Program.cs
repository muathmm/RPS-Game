namespace RPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("welcome in  Rock, Paper, Scissors game!");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("please enter your name");
                String name = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("get start the game ");
               
                Player player = new Player(name);
                AIPlayer aiPlayer = new AIPlayer("Player");

                RPSGame game = new RPSGame(player, aiPlayer);
                game.PlayGame();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
