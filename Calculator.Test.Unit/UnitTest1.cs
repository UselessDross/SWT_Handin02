namespace Calculator.Test.Unit
{
    public class UnitTest1
    {
        Calculator uut;

        private const double _precision = 1e-4;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [Test]
        public void Accumalator_InitialValue()
        {
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Clear_AccumulatorCorrect()
        {
            uut.Add(1, 1);
            uut.Clear();

            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }
        [Test]
        public void ClearTwice_AccumulatorCorrect()
        {
            uut.Add(1, 1);
            uut.Clear();
            uut.Clear();

            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }
        [Test]
        public void ClearFirst_AccumulatorCorrect()
        {
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

        [TestCase(9, 5.5f, 49.5)]
        [TestCase(9, 0, 0)]
        [TestCase(6, -3, -18)]
        public void Multiply_ResultCorrect(double a, double b, double result)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result).Within(_precision));
        }
        [TestCase(9, 5.5f, 49.5)]
        [TestCase(9, 0, 0)]
        [TestCase(6, -3, -18)]
        public void Multiply_AccumulatorCorrect(double a, double b, double result)
        {
            uut.Multiply(a, b);

            Assert.That(uut.Accumulator, Is.EqualTo(result).Within(_precision));
        }
        [TestCase(9, 5.5f, 2, 99)]
        [TestCase(9, 0, 2, 0)]
        [TestCase(6, -3, 4, -72)]
        public void MultiplyWithAccumulator(double a, double b, double c, double result)
        {
            uut.Multiply(a, b);

            Assert.That(uut.Multiply(c), Is.EqualTo(result).Within(_precision));
            Assert.That(uut.Accumulator, Is.EqualTo(result).Within(_precision));
        }

        [TestCase(9, 5, 59049)]
        [TestCase(2, -2, 0.25)]
        [TestCase(2, 0, 1)]
        [TestCase(10.3f, 2, 106.09)]
        public void Power_ResultCorrect(double a, double b, double result)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(result).Within(_precision));
        }
        [TestCase(9, 5, 59049)]
        [TestCase(2, -2, 0.25)]
        [TestCase(2, 0, 1)]
        [TestCase(10.3f, 2, 106.09)]
        public void Power_AccumulatorCorrect(double a, double b, double result)
        {
            uut.Power(a, b);

            Assert.That(uut.Accumulator, Is.EqualTo(result).Within(_precision));
        }
        [TestCase(2, 4, 3, 4096)]
        [TestCase(2, -2, 2, 0.0625)]
        [TestCase(1e+1, 2, 3, 1e+6)]
        public void PowerWithAccumulator(double a, double b, double c, double result)
        {
            uut.Power(a, b);

            Assert.That(uut.Power(c), Is.EqualTo(result).Within(_precision));
            Assert.That(uut.Accumulator, Is.EqualTo(result).Within(_precision));
        }
    }
}