using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ_Library;
using Xunit;

namespace ReceiverLibrary_Test
{
    public class ReceiverTests
    {
        //Test for positive result
        [Fact]
        public void ValidateMessage_ComplexValidInput_ReturnsExpectedResult()
        {
            //Arrange
            ValidationClass validator = new ValidationClass();
            string inputMessage = "Hello my name is, Benjamin";

            //Act
            string result = validator.ValidateMessage(inputMessage);

            //Assert
            Assert.Equal("Benjamin", result);
        }

        //Test for negative result
        [Fact]
        public void ValidateMessage_NoComma_ReturnsNull()
        {
            //Arrange
            ValidationClass validator = new ValidationClass();
            string inputMessage = "Hello my name is Benjamin";

            //Act
            string result = validator.ValidateMessage(inputMessage);

            //Assert
            Assert.Null(result);
        }
    }
}
