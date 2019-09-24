using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises_Sep2419;

namespace Exercises_Sep2419_Test
{
    [TestClass]
    public class Sep2419_Test
    {
        [TestMethod]
        public void Test_PrintName()
        {

            //Arrange
            string name = "Jane";
            string expected = $"Hello \n {name}";

            //Act
            string actual = Sep2419.PrintName(name);

            //Act
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SumOfNum()
        {
            //Arange
            int numOne = 5;
            int numTwo = 5;
            string expected = $"{numOne} + {numTwo} = {numOne + numTwo}";

            //Act
            string actual = Sep2419.SumOfNum(numOne, numTwo);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_DivTwoNum()
        {
            //Arrange 
            int numOne = 10;
            int numTwo = 2;
            string expected = $"{numOne} + {numTwo} = {numOne / numTwo}";

            //Act
            string actual = Sep2419.DivTwoNum(numOne, numTwo);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_SpecMathCal()
        {
            //Arrange 
            string expectedOperationOne = $"-1 + 4 * 6 = {(-1 + 4) * 6}";
            string expectedOperationTwo = $"( 35+ 5 ) % 7 = {(35 + 5) % 7}";
            string expectedOperationThree = $"14 + -4 * 6 / 11 = {(14 + -4) * (6 / 11)}";
            string expectedOperationFour = $"2 + 15 / 6 * 1 - 7 % 2 = {(2 + 15) / 6 * (1 - (7 % 2))}";

            string[] expectedOperations = {
                expectedOperationOne,
                expectedOperationTwo,
                expectedOperationThree,
                expectedOperationFour
            };

            //Act
            string[] actual = Sep2419.SpecMathCal();

            //Assert 
            //Actual and expected values are equal
            Assert.AreEqual(expectedOperations[0], actual[0]);
            Assert.AreEqual(expectedOperations[1], actual[1]);
            Assert.AreEqual(expectedOperations[2], actual[2]);
            Assert.AreEqual(expectedOperations[3], actual[3]);

            //expected operation one is not equal to any other operation
            Assert.AreNotEqual(expectedOperations[0], actual[1]);
            Assert.AreNotEqual(expectedOperations[0], actual[2]);
            Assert.AreNotEqual(expectedOperations[0], actual[3]);

            //expected operation two is not equal to any other operation
            Assert.AreNotEqual(expectedOperations[1], actual[0]);
            Assert.AreNotEqual(expectedOperations[1], actual[2]);
            Assert.AreNotEqual(expectedOperations[1], actual[3]);

            //expected operation three is not equal to any other operation
            Assert.AreNotEqual(expectedOperations[2], actual[0]);
            Assert.AreNotEqual(expectedOperations[2], actual[1]);
            Assert.AreNotEqual(expectedOperations[2], actual[3]);

            //expected operation four is not equal to any other operation
            Assert.AreNotEqual(expectedOperations[3], actual[0]);
            Assert.AreNotEqual(expectedOperations[3], actual[1]);
            Assert.AreNotEqual(expectedOperations[3], actual[2]);
        }

        [TestMethod]
        public void Test_SwapTwoNum()
        {
            //Arrange 
            int numOne = 5;
            int numTwo = 6;
            int[] expectedNum = { numTwo, numOne };

            //Act
            int[] actualNum = Sep2419.SwapTwoNum(numOne, numTwo);

            //Assert
            Assert.AreEqual(expectedNum[0], actualNum[0]);
            Assert.AreEqual(expectedNum[1], actualNum[1]);

            //expected numone is not equal to numtwo
            Assert.AreNotEqual(expectedNum[0], actualNum[1]);

            //expected numone is not equal to numtwo
            Assert.AreNotEqual(expectedNum[1], actualNum[0]);
        }
    }
}
