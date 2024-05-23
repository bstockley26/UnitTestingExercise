using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(4, 6, 2, 12)]
        [InlineData(3, 7, 9, 19)]
        [InlineData(2, 3, 4, 9)]
        //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calculator.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,4,-1)]
        [InlineData(6,3,3)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:
            var calculator = new Calculator();

            var actual = calculator.Subtract(minuend, subtrhend);

            Assert.Equal(expected, actual);
            //Arrange

            //Act

            //Assert

        }

        [Theory]
        [InlineData(3,3,9)]
        [InlineData(4,3,12)]
        [InlineData(5,5, 25)]
        //Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            var calculator = new Calculator();

            var actual = calculator.Multiply(num1, num2);

            Assert.Equal(expected, actual);
            //Arrange

            //Act

            //Assert

        }

        [Theory]
        [InlineData(8,4,2)]
        [InlineData(9,3,3)]
        [InlineData(8,4,2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();

            var actual = calculator.Divide(num1, num2);

            Assert.Equal(expected, actual);
            //Act

            //Assert

        }

    }
}
