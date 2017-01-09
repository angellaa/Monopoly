using NUnit.Framework;

namespace Monopoly.Tests
{
    public class GameTests
    {
        [Test]
        public void FirstPlayer()
        {
            var player1 = new Player("Player1");
            var player2 = new Player("Player2");

            var game = new Game();
            game.AddPlayer(player1);
            game.AddPlayer(player2);

            Assert.That(game.CurrentPlayer, Is.EqualTo(player1));
        }

        [Test]
        public void SecondPlayer()
        {
            var player1 = new Player("Player1");
            var player2 = new Player("Player2");

            var game = new Game();
            game.AddPlayer(player1);
            game.AddPlayer(player2);

            game.Next();

            Assert.That(game.CurrentPlayer, Is.EqualTo(player2));
        }

        [Test]
        public void FirstPlayer_SecondTurn()
        {
            var player1 = new Player("Player1");
            var player2 = new Player("Player2");

            var game = new Game();
            game.AddPlayer(player1);
            game.AddPlayer(player2);

            game.Next();
            game.Next();

            Assert.That(game.CurrentPlayer, Is.EqualTo(player1));
        }
    }
}
