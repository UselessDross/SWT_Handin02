namespace Calculator.Test.Unit
{
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void Add_ResultCorrect()
        {
           Calculator uut = new Calculator();

            Assert.That(uut.Add(9, 5), Is.EqualTo(14));
        }
        [Test]
        public void Add_AccumulatorCorrect()
        {
            Calculator uut = new Calculator();
            uut.Add(9, 5);

            Assert.That(uut.Accumulator, Is.EqualTo(14));
        }


        [Test]
        public void Subtract_ResultCorrect()
        {
            Calculator uut = new Calculator();

            Assert.That(uut.Subtract(9, 5), Is.EqualTo(4));
        }
        [Test]
        public void Subtract_AccumulatorCorrect()
        {
            Calculator uut = new Calculator();
            uut.Subtract(9, 5);

            Assert.That(uut.Accumulator, Is.EqualTo(4));
        }


        [Test]
        public void Multiply_ResultCorrect()
        {
            Calculator uut = new Calculator();

            Assert.That(uut.Multiply(9, 5), Is.EqualTo(45));
        }
        [Test]
        public void Multiply_AccumulatorCorrect()
        {
            Calculator uut = new Calculator();
            uut.Multiply(9, 5);

            Assert.That(uut.Accumulator, Is.EqualTo(45));
        }


        [Test]
        public void Power_ResultCorrect()
        {
            Calculator uut = new Calculator();

            Assert.That(uut.Power(9, 5), Is.EqualTo(59049));
        }
        [Test]
        public void Power_AccumulatorCorrect()
        {
            Calculator uut = new Calculator();
            uut.Power(9, 5);

            Assert.That(uut.Accumulator, Is.EqualTo(59049));
        }
    }
}