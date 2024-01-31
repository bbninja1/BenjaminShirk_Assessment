using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ_Sender;
using RabbitMQ_Library;
using Xunit;

namespace WorkerClassLibrary_Test
{
    public class WorkerClassTests
    {
        //Test for Name Validation
        [Theory]
        [InlineData("John", true)]            
        [InlineData("123", false)]            
        [InlineData("John Doe", false)]       
        [InlineData("", false)]               
        [InlineData(null, false)]             
        public void IsNameValid_Validations(string input, bool expectedResult)
        {
            //Arrange
            WorkerClass worker = new WorkerClass();

            //Act
            bool result = worker.isNameValid(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
