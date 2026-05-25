using NUnit.Framework;
using DVLARegistrationTestSystem.Services;
using DVLARegistrationTestSystem.Models;

namespace DVLARegistrationTestsNUnit
{
    public class Tests
    {
        private DVLARegistrationService service;
        //Runs before each test to set up the test environment
        [SetUp]
        public void Setup()
        {
            service = new DVLARegistrationService();
        }
        //Verifies that the total registration count is correct
        [Test]
        public void GetTotalRegistrationCount_ShouldReturn3()
        {
            Assert.AreEqual(3, service.GetTotalRegistrationCount());
        }
        //Verifies that the correct vehicle ID is returned for a valid registration number
        [Test] 
        public void GetVehicleId_ShouldReturnCorrectVehicleId() 
        { 
            Assert.AreEqual(12345, service.GetVehicleId("AB01 CDE")); 
        }
        //Verifies that null is returned when a registration number has no associated vehicle
        [Test] public void GetVehicleId_ShouldReturnNull_WhenNoVehicleAssigned()
        { 
            Assert.IsNull(service.GetVehicleId("L33T H4X0R"));
        }
        //Verifies that null is returned when a registration number does not exist in the system
        [Test]
        public void GetVehicleId_ShouldReturnNull_WhenRegistrationDoesNotExist() 
        { 
           Assert.IsNull(service.GetVehicleId("INVALID")); 
        }
        //Verifies exception is thrown when input is null
        [Test]
        public void GetVehicleId_ShouldThrowException_WhenInputIsNull() 

        { 
            Assert.Throws<ArgumentException>(() => service.GetVehicleId(null));
        }
        // Throws an exception when input is empty
        [Test]
        public void GetVehicleId_ShouldThrowException_WhenInputIsEmpty()
        { 
            Assert.Throws<ArgumentException>(() => service.GetVehicleId("")); 
        }
        //Verifies that null is returned when a registration number is invalid (not in the correct format)
        [Test]
        public void GetVehicleId_ShouldReturnNull_WhenRegistrationIsInvalid()
        {
            Assert.IsNull(service.GetVehicleId("XYZ999"));
        }
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}