using CalculatorAPIUnitTesting.Services;
using static CalculatorAPIUnitTesting.Services.CalculatorRepo;

namespace ClacTestProject
{
    public class Tests
    {

        CalculatorRepo _calculatorRepo;
        [SetUp]
        public void Setup()
        {
            _calculatorRepo = new CalculatorRepo();
        }

        [Test]
        public void Add_ReturnsCorrectResult()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Action
            int result = _calculatorRepo.Add(a, b);

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Subtract_ReturnsCorrectResult()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Action
            int result = _calculatorRepo.Subtract(a, b);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Multiply_ReturnsCorrectResult()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Action
            int result = _calculatorRepo.Multiply(a, b);

            // Assert
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Divide_ReturnsCorrectResult()
        {
            // Arrange
            int a = 6;
            int b = 3;

            // Action
            double result = _calculatorRepo.Divide(a, b);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Divide_ByZeroThrowsException()
        {
            // Arrange
            int a = 6;
            int b = 0;

            // Action/Assert
            Assert.Throws<CalculatorException>(() => _calculatorRepo.Divide(a, b));
        }
    }
}