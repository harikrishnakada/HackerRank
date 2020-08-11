using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public static class Algorithms
    {

        #region Binary Search Algorithm

        // double[] arr = new double[]{ 2, 5, 7, 10, 14, 25, 33, 52, 56, 74, 77 };
        //Practice.GetIndexUsingBinarySearch(arr, 52);
        public static int GetIndexUsingBinarySearch(double[] array, double target)
        {
            var lowerBound = 0;
            var upperBound = array.Length - 1;

            var targetFound = false;
            var midPoint = 0;
            int numberOfIterations = 0;

            while (!targetFound)
            {
                numberOfIterations++;
                if (upperBound < lowerBound)
                    break;
                midPoint = lowerBound + (upperBound - lowerBound) / 2;

                if(midPoint == 0 && array[midPoint] != target)
                {
                    return array.Length+1;
                }

                if (array[midPoint] < target)
                    lowerBound = midPoint + 1;
                if (array[midPoint] > target)
                    upperBound = midPoint - 1;
                if(array[midPoint] == target)
                {
                    targetFound = true;
                    break;
                }
            }

            Console.WriteLine("Number of iterations: " + numberOfIterations);

            return midPoint;
        }

        #endregion Binary Search Algorithm
    }
}
