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

        
        [TestCase(1, 2,  0)]
        [TestCase(3, 3, 0)]
        [TestCase(22, 22, 0)]

        public void Clear_AccumulatorCorrect(double a,double b,double  result)
        {
            uut.Add(a, b);
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }


        [TestCase(1, 2, 3)]
        [TestCase(3, 3, 6)]
        [TestCase(9, 1, 10)]
        public void Add_ResultCorrect(double a, double b, double result)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, 3, 6)]
        [TestCase(9, 1, 10)]
        public void Add_AccumulatorCorrect(double a, double b, double result)
        {
            uut.Add(b,a);

            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(1, 1, 1, 3)]
        [TestCase(1, 1, 2, 4)]
        [TestCase(1, 1, 3, 5)]
        public void AddWithAccumulator(double a, double b, double c,double result)
        {
            uut.Add(a, b);

            Assert.That(uut.Add(c), Is.EqualTo(result));
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(9, 6, 3)]
        [TestCase(10, 3, 7)]
        [TestCase(9, 1, 8)]
        public void Subtract_ResultCorrect(double a, double b, double result)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }
        [TestCase(9, 6, 3)]
        [TestCase(10, 3, 7)]
        [TestCase(9, 1, 8)]
        public void Subtract_AccumulatorCorrect(double a, double b, double result)
        {
            uut.Subtract(a, b);

            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }
        [TestCase(8, 1, 1, 6)]
        [TestCase(10, 1, 2, 7)]
        [TestCase(3, 1, 2, 0)]
        public void SubtractWithAccumulator(double a, double b, double c, double result)
        {
            uut.Subtract(a, b);

            Assert.That(uut.Subtract(c), Is.EqualTo(result));
            Assert.That(uut.Accumulator, Is.EqualTo(result));
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