using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    // Try and add all the scenarios implementing the tests
    // Make sure to check all the execution paths. and create a test based on that number

    // Also remember that unit tests must not call any external code, Keep it Simple.

    // Add TestMethods must be public void

    [TestFixture]
    public class ReservationTests
    {
        // CanBeCanceledBy_Scenario_ExpectedBehaviour
        [Test]
        public void CanBeCanceledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange - Prepare
            var reservation = new Reservation();

            // Act - call the method to test.
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.IsTrue(result);
            // Assert.That(result, Is.True);
            // Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_UserMadeReservation_ReturnsTrue()
        {
            // Arrange 
            var user = new User() { IsAdmin = false };
            var reservation = new Reservation() { MadeBy = user };
            
            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCanceledBy_UserNotAdminOrMade_ReturnsFalse()
        {
            // Arrange
            var user = new User { IsAdmin = false };
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
