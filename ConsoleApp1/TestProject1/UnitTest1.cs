
using Microsoft.VisualStudio.TestPlatform.TestHost;
using ConsoleApp1;
using Program = ConsoleApp1.Program;
using PersonDetails = ConsoleApp1.PersonDetails;

namespace TestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            // Arrange
            var program = new Program();
            var personDetails = new PersonDetails
            {
                Name = "John",
                Address = "123 Main St",
                Age = 30,
                Gender = "M"
            };

            // Act
            bool result = program.Function(personDetails);

            // Assert
            Assert.False(result);
        }

    }
}