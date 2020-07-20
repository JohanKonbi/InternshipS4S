using Microsoft.VisualStudio.TestTools.UnitTesting;
using InternShipPipeline;
using System;
using System.Security.Cryptography;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Substract_7from5()
        {
            //Arrange
            int expected1 = -2;
            //Act
            int actual1 = AllMethods.Substract(5, 7);
            //Assert
            Assert.AreEqual(expected1, actual1);
        }
        [TestMethod]
        public void Substract_7from12()
        {
            //Arrange
            int expected2 = 5;
            //Act
            int actual2 = AllMethods.Substract(12, 7);
            //Assert
            Assert.AreEqual(expected2, actual2);
        }
        [TestMethod]
        public void Sort_By_FirstName()
        {
            //Arrange
            string[] expected = new string[] { "Abraham", "Boris", "Christine", "Dharwin", "Evelynn" };
            //Act
            string[] actual = AllMethods.OrderBy(0);
            //Assert
            //Assert.AreEqual(expected,actual);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
        [TestMethod]
        public void Sort_By_LastName()
        {
            //Arrange
            string[] expected = new string[] { "Evelynn", "Dharwin", "Christine", "Boris", "Abraham" };
            //Act
            string[] actual = AllMethods.OrderBy(1);
            //Assert
            //Assert.AreEqual(expected,actual);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
