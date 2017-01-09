using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace Monopoly
{
    public class Game
    {
        private readonly List<Player> players = new List<Player>();
        private readonly List<Dice> dices = new List<Dice>();
        
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

        public void AddDice(Dice dice)
        {
            dices.Add(dice);
        }

        public void Play()
        {
            foreach (var dice in dices)
            {
                 dice.Roll();          
            }
        }

        public int DiceValue
        {
            get { return dices.Select(v => v.Value.Value).Sum(); }
        }
    }
}