using System;

namespace Monopoly
{
    public class Dice
    {
        private readonly Random random;
        private readonly int min;
        private readonly int max;
        private int? value;

        public Dice(int min, int max)
        {
            random = new Random(Guid.NewGuid().GetHashCode());
            this.min = min;
            this.value = null;
            this.max = max;
        }

        public int? Value
        {
            get { return value; }
            set
            {
                if (value > max || value < min)
                {
                    throw new ArgumentException();
                }

                this.value = value;
            }
        }

        public void Roll()
        {
           Value = random.Next(min, max);
        }
    }
}