namespace NUnitDemo
{
    public class Tests
    {
        Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();

        }

        [Test]
        public void Add_WhenCalled_ReturnsSumOfTwoNumbers()
        {
            int a = 5;
            int b = 10;

            int result = calculator.Add(a, b);

            Assert.That(result, Is.EqualTo(15));
        }
        [Test]
        public void Subtract_WhenCalled_ReturnsDifferenceOfTwoNumbers()
        {
            int a = 10;
            int b = 5;

            int result = calculator.Subtract(a, b);

            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void Multiply_WhenCalled_ReturnsProductOfTwoNumbers()
        {
            int a = 5;
            int b = 10;

            int result = calculator.Multiply(a, b);

            Assert.That(result, Is.EqualTo(50));
        }
        [Test]
        public void Divide_WhenCalled_ReturnsQuotientOfTwoNumbers()
        {
            int a = 10;
            int b = 2;

            int result = calculator.Divide(a, b);

            Assert.That(result, Is.EqualTo(5));
        }
    }
}