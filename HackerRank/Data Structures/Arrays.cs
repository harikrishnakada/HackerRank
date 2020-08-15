﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Data_Structures
{
    public static class Arrays
    {
        #region https://www.hackerrank.com/challenges/array-left-rotation/problem

        public static int[] leftRotations(int[] arr, int leftRotations)
        {
            int temp;
            int start = 0;
            int end = arr.Length - 1;

            while (start < leftRotations)
            {
                int first = arr[0];
                int j = 0;
                while (j < end)
                {
                    arr[j] = arr[j + 1];
                    j++;
                }
                arr[end] = first;
                start++;
            }
            Console.Write(string.Join(" ", arr));
            return arr;
        }

        public static int[] leftRotationsOptimised(int[] arr, int leftRotations)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[(i + arr.Length - leftRotations) % arr.Length] = arr[i];
            }
            Console.Write(string.Join(" ", arr));

            return arr;
        }

        #endregion https://www.hackerrank.com/challenges/array-left-rotation/problem

        #region https://www.hackerrank.com/challenges/arrays-ds/problem

        public static int[] reverseArrayUisngLinq(int[] arr)
        {
            return arr.Reverse().ToArray();
        }

        public static int[] reverseIntArrayUsingLogic(int[] arr)
        {
            int temp;
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

            return arr;
        }

        #endregion https://www.hackerrank.com/challenges/arrays-ds/problem

        #region https://www.hackerrank.com/challenges/2d-array/problem
        public static int hourGlass(int[][] arr)
        {
            var sumCollection = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sumCollection.Add(arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]);
                }
            }
            return sumCollection.Max();
        }
        #endregion https://www.hackerrank.com/challenges/2d-array/problem
    }
}