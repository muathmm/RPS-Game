using RPS;

public class AIPlayer : Player
{
    private static Random random = new Random();
    private string lastPlayerMove;

    public AIPlayer(string name) : base(name)
    {
        lastPlayerMove = null;
    }

    public string ChooseMove()
    {
        string[] moves = { "r", "p", "s" };
        return moves[random.Next(moves.Length)];
    }


    public string CheatMove()
    {
        if (lastPlayerMove == null)
        {
         
            return ChooseMove();
        }
        else
        {
         
            switch (lastPlayerMove)
            {
                case "r":
                    return "p"; 
                case "p":
                    return "s"; 
                case "s":
                    return "r"; 
                default:
                    return ChooseMove(); 
            }
        }
    }

   
    public void SetLastPlayerMove(string move)
    {
        lastPlayerMove = move;
    }
}
