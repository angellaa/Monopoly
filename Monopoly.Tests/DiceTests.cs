using System;
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

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void SetValue(int value)
        {
            var dice = new Dice(1, 3) { Value = value };

            Assert.That(dice.Value, Is.EqualTo(value));
        }

        [TestCase(1)]
        [TestCase(6)]
        public void SetInvalidValue(int invalidValue)
        {
            var dice = new Dice(2, 5);
            Assert.Throws<ArgumentException>(() => dice.Value = invalidValue);
        }
    }
}
