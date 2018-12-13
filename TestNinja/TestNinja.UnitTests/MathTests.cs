using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Fundamentals.Math _math;

        // NUnit has SetUp and TearDown attribute to allow us to call a method before and/or after a test run
        [SetUp]
        public void SetUp()
        {
            // Arrange
            _math = new Fundamentals.Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            // Act
            var result = _math.Add(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        // Try and add all the scenarios implementing the tests
        // Make sure to check all the execution paths. and create a test based on that number

        // Also remember that unit tests must not call any external code, Keep it Simple.

        [Test]
        [Ignore("THIS TEST IS REDUNDANT BECAUSE OF THE GENERIC TEST")]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
        {
            // THIS TEST IS REDUNDANT BECAUSE OF THE GENERIC TEST

            // Act
            var result = _math.Max(2, 1);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        {
            // THIS TEST IS REDUNDANT BECAUSE OF THE GENERIC TEST

            var result = _math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentAreEqual_ReturnSameArgument()
        {
            // THIS TEST IS REDUNDANT BECAUSE OF THE GENERIC TEST

            var result = _math.Max(1, 1);

            Assert.That(result, Is.EqualTo(1));
        }

        // Generic test Method
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreatestArgument(int a, int b, int expected)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetOddNumbers_
    }
}
