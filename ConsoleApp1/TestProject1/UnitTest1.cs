using ConsoleApp1.Classes;

namespace TestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void TestPersonDetails()
        {
            // Arrange
            var personDetails = new PersonDetails
            {
                Name = "John",
                Address = "123 Main St",
                Age = 30,
                PayrollDetail = new PersonDetails.Payroll
                {
                    HoursWork = 40,
                    Rate = 20
                }
            };

            // Act
            var name = personDetails.Name;
            var address = personDetails.Address;
            var age = personDetails.Age;
            var hoursWork = personDetails.PayrollDetail?.HoursWork;
            var rate = personDetails.PayrollDetail?.Rate;

            // Assert
            Assert.Equal("John", name);
            Assert.Equal("123 Main St", address);
            Assert.Equal(30, age);
            Assert.Equal(40, hoursWork);
            Assert.Equal(20, rate);

            //Assert.Equal(, rate);
        }

        [Fact]
        public void TestAddPersonDetailsToList()
        {
            // Arrange
            var program = new PersonDetails();
            var personDetailsList = new List<PersonDetails>();
            var personDetails = new PersonDetails
            {
                Name = "John",
                Address = "123 Main St",
                Age = 30,
                PayrollDetail = new PersonDetails.Payroll
                {
                    HoursWork = 40,
                    Rate = 20
                }
            };

            // Act
            program.AddPersonDetailsToList(personDetailsList, personDetails);

            // Assert
            Assert.Single(personDetailsList);
            Assert.Equal("John", personDetails.Name);
            Assert.Equal("123 Main St", personDetails.Address);
            Assert.Equal(30, personDetails.Age);
            Assert.Equal(40, personDetails.PayrollDetail.HoursWork);
            Assert.Equal(20, personDetails.PayrollDetail.Rate);
        }

        [Fact]
        public void TestCalculatePay()
        {
            // Arrange
            var program = new PersonDetails();
            var personDetails = new PersonDetails()
            {
                PayrollDetail = new PersonDetails.Payroll()
                {
                    HoursWork = 40,
                    Rate = 10
                }
            };

            // Act
            var pay = program.CalculatePay(personDetails);

            // Assert
            Assert.Equal(personDetails.PayrollDetail.HoursWork + personDetails.PayrollDetail.Rate, pay);
        }

        [Fact]
        public void TestId()
        {
            //Arrange
            var program = new PersonDetails();
            var personDetailsList = new List<PersonDetails>();
            var personDetails = new PersonDetails()
            {
                Id = "1"
                
            };

            personDetailsList.Add(personDetails);

            //Act
            var id = program.SetId(personDetailsList.Count);

            //Assert
            Assert.Equal("Dili", id);

        }

        [Fact]
        public void TestIdForElse()
        {
            //Arrange
            var program = new PersonDetails();
            var personDetailsList = new List<PersonDetails>();
            var personDetails = new PersonDetails()
            {
                Id = "1"

            };

            personDetailsList.Add(personDetails);
            personDetailsList.Add(personDetails);

            //Act
            var id = program.SetId(personDetailsList.Count);

            //Assert
            Assert.Equal("Divisible by 2", id);

        }

    }
}