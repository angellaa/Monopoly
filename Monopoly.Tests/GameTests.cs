using NUnit.Framework;

namespace Monopoly.Tests
{
    public class GameTests
    {
        [Test]
        public void New()
        {
            var player1 = new Player("Player1");
            var player2 = new Player("Player1");

            var game = new Game();
            game.AddPlayer(player1);
            game.AddPlayer(player2);

            Assert.That(game.CurrentPlayer, Is.EqualTo(player1));
        }
    }
}
