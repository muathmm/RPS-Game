using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPS
{
    public class RPSGame
    {
        private Player player;
        private AIPlayer aiPlayer;

        public RPSGame(Player p, AIPlayer ai)
        {
            player = p;
            aiPlayer = ai;
        }

        public void PlayRound()
        {
            Console.WriteLine($"{player.Name}, choose [r]ock, [p]aper, or [s]cissors:");
            string move = Console.ReadLine().ToLower();
            string playerMove = player.ChooseMove(move);
        
            string aiMove = aiPlayer.ChooseMove();

            Console.WriteLine($"{player.Name} chose( {MoveToString(playerMove)})");
            Console.WriteLine($"{aiPlayer.Name} chose ({MoveToString(aiMove)})");

            int result = CompareMoves(playerMove, aiMove);

            if (result == 1)
            {
                Console.WriteLine($"{player.Name} wins the round!");
                player.Score++;
            }
            else if (result == -1)
            {
                Console.WriteLine($"{aiPlayer.Name} wins the round!");
                aiPlayer.Score++;
            }
            else
            {
                Console.WriteLine("The round is a tie!");
            }
        }

        public int CompareMoves(string move1, string move2)
        {
            if (move1 == move2) return 0;

            if ((move1 == "r" && move2 == "s") ||
                (move1 == "p" && move2 == "r") ||
                (move1 == "s" && move2 == "p"))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        private string MoveToString(string move)
        {
            switch (move)
            {
                case "r":
                    return "Rock";
                case "p":
                    return "Paper";
                case "s":
                    return "Scissors";
                default:
                    return "";
            }
        }

        public void DisplayScores()
        {
            Console.WriteLine($"{player.Name}: {player.Score}");
            Console.WriteLine($"{aiPlayer.Name}: {aiPlayer.Score}");
        }

        public void PlayGame()
        {
          
       

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Round {i}");
                PlayRound();
                DisplayScores();
                Thread.Sleep(5000);
                Console.Clear();
                

                if (player.Score == 3 || aiPlayer.Score == 3)
                {
                    break;
                }
            }

            Console.WriteLine("Game over!");
            DisplayScores();

            if (player.Score > aiPlayer.Score)
            {
                Console.WriteLine($"{player.Name} wins the game!");
            }
            else if (aiPlayer.Score > player.Score)
            {
                Console.WriteLine($"{aiPlayer.Name} wins the game!");
            }
            else
            {
                Console.WriteLine("The game is a tie!");
            }
        }
    }
}
