using Xunit;
using ArrayLibrary;
using System;

namespace ArrayLibrary.Tests
{
    public class ArrayHelperTests
    {
        [Fact]
        public void FindMax_ShouldReturnMaximumValue()
        {
            int[] arr = { 1, 5, 9, 3, 7 };
            int result = ArrayHelper.FindMax(arr);
            Assert.Equal(9, result);
        }

        [Fact]
        public void FindMin_ShouldReturnMinimumValue()
        {
            int[] arr = { 1, 5, 9, 3, 7 };
            int result = ArrayHelper.FindMin(arr);
            Assert.Equal(1, result);
        }

        [Fact]
        public void FindMax_ShouldThrowException_WhenArrayIsEmpty()
        {
            int[] arr = { };
            Assert.Throws<ArgumentException>(() => ArrayHelper.FindMax(arr));
        }

        [Fact]
        public void FindMin_ShouldThrowException_WhenArrayIsNull()
        {
            int[] arr = null;
            Assert.Throws<ArgumentException>(() => ArrayHelper.FindMin(arr));
        }
    }
}

