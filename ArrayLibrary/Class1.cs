using System;
using System.Linq;

namespace ArrayLibrary
{
    public class ArrayHelper
    {
        public static int FindMax(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Array is empty or null");
            return arr.Max();
        }

        public static int FindMin(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Array is empty or null");
            return arr.Min();
        }
    }
}


