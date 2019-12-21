using System;
using MinDrivesTest;
using Xunit;

namespace MinDrivesTest_XUnitTest
{
    public class DiskSpaceTest
    {
        [Fact]
        public void MinDrivesLinqResult5()
        {
            //Arrange
            var used = new int[] { 750, 800, 850, 900, 950 };
            var total = new int[] { 800, 850, 900, 950, 1000 };
            //Act
            var result = DiskSpace.MinDrivesLinq(used, total);
            //Assert
            Assert.IsType<int>(result);
            Assert.True(result == 5);
        }

        [Fact]
        public void MinDrivesConventionalresult5()
        {
            //Arrange
            var used = new int[] { 750, 800, 850, 900, 950 };
            var total = new int[] { 800, 850, 900, 950, 1000 };
            //Act
            var result = DiskSpace.MinDrivesConventional(used, total);
            //Assert                             
            Assert.IsType<int>(result);
            Assert.True(result == 5);
        }

        [Fact]
        public void MinDrivesLinqResult1()
        {
            //Arrange
            var used = new int[] { 1, 200, 200, 199, 200, 200 };
            var total = new int[] { 1000, 200, 200, 200, 200, 200 };
            //Act
            var result = DiskSpace.MinDrivesLinq(used, total);
            //Asserts
            Assert.IsType<int>(result);
            Assert.True(result == 1);
        }

        [Fact]
        public void MinDrivesConventionalResult1()
        {
            //Arrange
            var used = new int[] { 1, 200, 200, 199, 200, 200 };
            var total = new int[] { 1000, 200, 200, 200, 200, 200 };
            //Act
            var result = DiskSpace.MinDrivesConventional(used, total);
            //Asserts
            Assert.IsType<int>(result);
            Assert.Equal(1, result);
        }

        [Fact]
        public void MinDrivesLinqResult49()
        {
            //Arrange
            var used = new int[] { 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49 };
            var total = new int[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 };
            //Act
            var result = DiskSpace.MinDrivesLinq(used, total);
            //Asserts
            Assert.IsType<int>(result);
            Assert.True(result == 49);
        }

        [Fact]
        public void MinDrivesConventionalResult49()
        {
            //Arrange
            var used = new int[] { 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49 };
            var total = new int[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 };
            //Act
            var result = DiskSpace.MinDrivesConventional(used, total);
            //Asserts
            Assert.IsType<int>(result);
            Assert.Equal(49, result);
        }
    }
}
