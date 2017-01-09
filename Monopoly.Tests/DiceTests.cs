using NUnit.Framework;

namespace Monopoly.Tests
{
    public class DiceTests
    {
        [Test]
        public void New()
        {
            var dice = new Dice(1, 6);

            Assert.IsNull(dice.Value);
        }

        [Test]
        public void Roll()
        {
            var dice = new Dice(1, 6);
            dice.Roll();

            Assert.That(dice.Value, Is.InRange(1, 6));
        }

        [Test]
        public void SingleValueRoll()
        {
            var dice = new Dice(1);
            dice.Roll();

            Assert.That(dice.Value, Is.EqualTo(1));
        }
    }
}
