using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    internal class MaxMinArray
    {
        void Main(string[] args)
        {
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++) {
               arr[i]=int.Parse( Console.ReadLine());
            }

            FindMaxMin(arr);
        }

        void FindMaxMin(int[] arr)
        {
            int min;
            min = arr[0];
            int max;
            max = arr[0];

            for (int j = 0; j < arr.Length; j++) {
                if (arr[j] > max)
                {
                    max = arr[j];
                }
                else if (arr[j] < min)
                {
                    min = arr[j];
                }
            }

            Console.WriteLine(max.ToString(), min.ToString());
        }

    }
}
