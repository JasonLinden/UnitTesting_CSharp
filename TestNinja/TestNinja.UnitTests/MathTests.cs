using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            // Arrange
            var math = new Fundamentals.Math();

            // Act
            var result = math.Add(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        // Try and add all the scenarios implementing the tests

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
        {

        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        {

        }

        [Test]
        public void Max_ArgumentAreEqual_ReturnSameArgument()
        {

        }
    }
}
