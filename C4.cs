using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL___GT_B4_C4
{
    internal class C4
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

            while (left <= right)
            {
                int mid1 = left + (right - left) / 3;
                int mid2 = right - (right - left) / 3;

                if (arr[mid1] == value)
                    return mid1;
                if (arr[mid2] == value)
                    return mid2;

                if (value < arr[mid1])
                    right = mid1 - 1;
                else if (value > arr[mid2])
                    left = mid2 + 1;
                else
                {
                    left = mid1 + 1;
                    right = mid2 - 1;
                }
            }

            return -1;
        }
    }
}
