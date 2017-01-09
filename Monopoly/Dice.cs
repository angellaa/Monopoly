using System;

namespace Monopoly
{
    public class Dice
    {
        private readonly Random random;
        private readonly int min;
        private readonly int max;

        public Dice(int min, int max)
        {
            random = new Random();
            this.min = min;
            this.max = max;
        }

        public int? Value { get; set; }

        public void Roll()
        {
           Value = random.Next(min, max);
        }
    }
}