﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL___GT_B4_C3
{
    internal class C3
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = { 12, 42, 13, 41, 125, 236, 37 };
            Array.Sort(arr);
            int a = BinSearch(arr, 13);
            Console.WriteLine(a + 1);
        }
        static int BinSearch(int[] arr, int value)
        {
            int left = 0, right = arr.Length - 1;
            Random random = new Random();
            while (left <= right)
            {
                int mid = random.Next(left, right);
                if (arr[mid] == value)
                    return mid;
                else if (value > arr[mid])
                    left = mid + 1;
                else if (value < arr[mid])
                    right = mid - 1;

            }
            return -1;

        }
    }
}
