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

    }
}