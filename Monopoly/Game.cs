using System.Collections.Generic;

namespace Monopoly
{
    public class Game
    {
        private readonly List<Player> players = new List<Player>();
        private readonly int currentPlayerIndex = 0;

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public Player CurrentPlayer => players[currentPlayerIndex];
    }
}