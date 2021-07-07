using NUnit.Framework;
using Cab_Invoice_Generator;

namespace Cab_Invoice_Generator_Test
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = null;
        [SetUp]
        public void Setup()
        {

        }
        /// <summary>
        /// Test Case For checking Calculate Fare Function
        /// </summary>

        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            //Arrange
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            //Act
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;
            //Assert
            Assert.AreEqual(expected, fare);
        }
        /// <summary>
        /// Test Case For Checking Multiple Rides
        /// </summary>
        [Test]
        public void GivenMultipleRideShouldReturnInvoiceSummary()
        {
            //Arrange
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(2.0, 5) };
            //Act
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 50.0);
            //Assert
            Assert.AreEqual(expectedSummary, summary);
        }
    }
}      

