using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL___GT_B4_C2
{
    internal class C2
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = { 12, 42, 13, 41, 125, 236, 37 };
            Array.Sort(arr);
            int a = Binsearch(arr, 13, 0, arr.Length - 1);
            Console.WriteLine(a + 1);

        }
        static int Binsearch(int[] arr, int value, int left, int right)
        {

            if (left > right)
                return -1;
            int mid = (left + right) / 2;
            if (arr[mid] == value)
                return mid;
            else if (value > arr[mid])
                return Binsearch(arr, value, left + 1, right);
            return Binsearch(arr, value, left, right - 1);


            /*while ( left <= right )
            {
                int mid = (left + right) / 2;
                if ( arr[mid] == value ) 
                    return mid;
                else if (value > arr[mid])
                    left = mid + 1;
                else if (value < arr[mid])
                    right = mid - 1;

            }
            return -1;*/

        }
    }
}
