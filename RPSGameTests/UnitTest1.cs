using RPS;

namespace RPSGameTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCompareMoves_RockVsScissors()
        {
            RPSGame game = new RPSGame(new Player("Test1"), new AIPlayer("TestAI"));
            Assert.Equal(1, game.CompareMoves("r", "s"));
        }

        [Fact]
        public void TestCompareMoves_PaperVsRock()
        {
            RPSGame game = new RPSGame(new Player("Test1"), new AIPlayer("TestAI"));
            Assert.Equal(1, game.CompareMoves("p", "r"));
        }

        [Fact]
        public void TestCompareMoves_ScissorsVsPaper()
        {
            RPSGame game = new RPSGame(new Player("Test1"), new AIPlayer("TestAI"));
            Assert.Equal(1, game.CompareMoves("s", "p"));
        }

        [Fact]
        public void TestCompareMoves_Tie()
        {
            RPSGame game = new RPSGame(new Player("Test1"), new AIPlayer("TestAI"));
            Assert.Equal(0, game.CompareMoves("r", "r"));
        }
        [Theory]
        [InlineData("r")]
        [InlineData("p")]
        [InlineData("s")]
        public void TestChooseMove_ValidInput(string move)
        {
            // Arrange
            Player player = new Player("Test");

            // Act
            string result = player.ChooseMove(move);

            // Assert
            Assert.Contains(result, new[] { "r", "p", "s" });
        }
        [Fact]
        public void TestCompareMoves_PlayerWins()
        {
            // Arrange
            var player = new Player("Player");
            var aiPlayer = new AIPlayer("AI");
            var game = new RPSGame(player, aiPlayer);

            // Act
            int result = game.CompareMoves("r", "s"); 

            // Assert
            Assert.Equal(1, result); 
        }

        [Fact]
        public void TestCompareMoves_AIWins()
        {
            // Arrange
            var player = new Player("Player");
            var aiPlayer = new AIPlayer("AI");
            var game = new RPSGame(player, aiPlayer);

            // Act
            int result = game.CompareMoves("s", "r"); 

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void TestUpdateScores_PlayerWinsRound()
        {
            // Arrange
            var player = new Player("Player");
            var aiPlayer = new AIPlayer("AI");
            var game = new RPSGame(player, aiPlayer);

            // Act
            player.Score = 0;
            aiPlayer.Score = 0;
            game.CompareMoves("s", "p");

            // Assert
            Assert.Equal(1, player.Score);
            Assert.Equal(0, aiPlayer.Score); 
        }

        [Fact]
        public void TestUpdateScores_AIWinsRound()
        {
            // Arrange
            var player = new Player("Player");
            var aiPlayer = new AIPlayer("AI");
            var game = new RPSGame(player, aiPlayer);

            // Act
            player.Score = 0;
            aiPlayer.Score = 0;
            game.CompareMoves("r", "p"); 

            // Assert
            Assert.Equal(0, player.Score); 
            Assert.Equal(1, aiPlayer.Score);
        }
    }
}