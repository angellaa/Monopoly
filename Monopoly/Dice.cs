using System;

namespace Monopoly
{
    public class Dice
    {
        private readonly Random random;
        private readonly int min;
        private readonly int max;

        public Dice(int value) : this(value, value)
        {
        }

        public Dice(int min, int max)
        {
            random = new Random(Guid.NewGuid().GetHashCode());
            this.min = min;
            this.Value = null;
            this.max = max;
        }

        public int? Value { get; private set; }

        public void Roll()
        {
           Value = random.Next(min, max);
        }
    }
}