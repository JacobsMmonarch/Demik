using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demik;
using System;

namespace Demik.Tests
{
    [TestClass()]
    public class DemikTests
    {
        [TestMethod()]
        public void SumTest()
        {
            // Arrange
            int value1 = 1;
            int value2 = 1;
            int expected = 2;

            // Act
            int actual = value1 + value2;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
