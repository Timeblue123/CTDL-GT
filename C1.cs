using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL___GT_B4
{
    internal class C1
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = { 12, 42, 13, 41, 125, 236, 37 };
            Console.WriteLine(SenSearch(arr, 37, 0) + 1);

        }
        static int SenSearch(int[] arr, int value,int index)
        {
            int lastele = arr[arr.Length-1];
            if (value == lastele)

                return arr.Length - 1;

            else if (arr[index] == value)

                return index;

            else if (index >= arr.Length-1 )
                return -1;
            
            return SenSearch(arr, value, index + 1);
            
         
        }
    }
}
