using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public string ChooseMove( String move)
        {
           
          

            while (move != "r" && move != "p" && move != "s")
            {
                Console.WriteLine("Invalid input. Please choose [r]ock, [p]aper, or [s]cissors:");
                move = Console.ReadLine().ToLower();
            }

            return move;
        }

    }
}
