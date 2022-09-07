namespace Calculator.Test.Unit
{
    public class UnitTest1
    {
        Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [Test]
        public void Clear_AccumulatorCorrect()
        {
            uut.Add(1, 1);
            uut.Clear();

            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Add_ResultCorrect()
        {
            Assert.That(uut.Add(9, 5), Is.EqualTo(14));
        }
        [Test]
        public void Add_AccumulatorCorrect()
        {
            uut.Add(9, 5);

            Assert.That(uut.Accumulator, Is.EqualTo(14));
        }
        [Test]
        public void AddWithAccumulator()
        {
            uut.Add(5, 5);

            Assert.That(uut.Add(4), Is.EqualTo(14));
            Assert.That(uut.Accumulator, Is.EqualTo(14));
        }

        [Test]
        public void Subtract_ResultCorrect()
        {
            Assert.That(uut.Subtract(9, 5), Is.EqualTo(4));
        }
        [Test]
        public void Subtract_AccumulatorCorrect()
        {
            uut.Subtract(9, 5);

            Assert.That(uut.Accumulator, Is.EqualTo(4));
        }
        [Test]
        public void SubtractWithAccumulator()
        {
            uut.Subtract(9, 2);

            Assert.That(uut.Subtract(3), Is.EqualTo(4));
            Assert.That(uut.Accumulator, Is.EqualTo(4));
        }

        [Test]
        public void Multiply_ResultCorrect()
        {
            Assert.That(uut.Multiply(9, 5), Is.EqualTo(45));
        }
        [Test]
        public void Multiply_AccumulatorCorrect()
        {
            uut.Multiply(9, 5);

            Assert.That(uut.Accumulator, Is.EqualTo(45));
        }
        [Test]
        public void MultiplyWithAccumulator()
        {
            uut.Multiply(3, 3);

            Assert.That(uut.Multiply(5), Is.EqualTo(45));
            Assert.That(uut.Accumulator, Is.EqualTo(45));
        }

        [Test]
        public void Power_ResultCorrect()
        {
            Assert.That(uut.Power(9, 5), Is.EqualTo(59049));
        }
        [Test]
        public void Power_AccumulatorCorrect()
        {
            uut.Power(9, 5);

            Assert.That(uut.Accumulator, Is.EqualTo(59049));
        }
        [Test]
        public void PowerWithAccumulator()
        {
            uut.Power(2, 4);

            Assert.That(uut.Power(3), Is.EqualTo(4096));
            Assert.That(uut.Accumulator, Is.EqualTo(4096));
        }
    }
}