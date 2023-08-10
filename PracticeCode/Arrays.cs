﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    internal class Arrays
    {
        static void printMaxElement(int[] arr)
        {
            int max = arr[0];
            for (int i=1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("The maximum element is: " + max);
        }

        static void printMinElement(int[] arr)
        {
            int min = arr[0];
            for (int i=1; i<arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("The minimum element is: " + min);
        }
        public static void Main(string[] args)
        {
            int[] arr1 = {2,4,7,343,322,87,34};
            int[] arr2 = {87,4635,7,242,8,353,89};

            printMaxElement(arr1); 
            printMaxElement(arr2);
            printMinElement(arr1);
            printMinElement(arr2);
        }
    }
}
