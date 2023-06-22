using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calcTest = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calcTest.Add(num1, num2, num3);
            //Assert
                //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.subtract( minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5 , 5 , 25)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multTest = new Calculator();
            //Act
            var MultActual = multTest.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, MultActual);
        }

        [Theory]
        [InlineData(45 , 5, 9)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var Dividecalc = new Calculator();
            //Act
            var DivisionActual = Dividecalc.Divide(num1,num2);
            //Assert
            Assert.Equal(expected, DivisionActual);
        }
        [Theory]
        [InlineData(4,4, 0)]
        [InlineData(5,3 , 2)]
        public void ModulusTest(int num1, int num2, int expected)
        {
            var ModulusCalc = new Calculator();

            var ModulusActual = ModulusCalc.Modulus(num1, num2);

            Assert.Equal(expected, ModulusActual);
        }

    }
}
