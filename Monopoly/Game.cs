using System.Collections.Generic;

namespace Monopoly
{
    public class Game
    {
        private readonly List<Player> players = new List<Player>();
        private int currentPlayerIndex;

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public Player CurrentPlayer => players[currentPlayerIndex];

        public void Next()
        {
            currentPlayerIndex = (currentPlayerIndex + 1) % players.Count;
        }
    }
}