using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL___GT_C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập số môn: ");
            uint mon;
            double x;
            string a = Console.ReadLine();
            while (!uint.TryParse(a, out mon))
            {
                Console.WriteLine("nhập sai, xin nhập lại");
                a = Console.ReadLine();
            }
            Array diem = Array.CreateInstance(typeof(double), mon);
            for (int i = diem.GetLowerBound( 0) ; i < diem.GetUpperBound(0) + 1; i++) 
            {
                Console.Write($"nhập điểm môn {i + 1}: ");
                string b = Console.ReadLine();
                while (!double.TryParse(b, out x) || x > 10)
                {
                    Console.WriteLine("nhập sai, xin nhập lại");
                    b = Console.ReadLine();
                }
                diem.SetValue(x,i);
                
            }
            for (int i = diem.GetLowerBound(0); i < diem.GetUpperBound(0) + 1; i++)
            {
                Console.Write($"điểm môn {i + 1}:");
                Console.WriteLine(diem.GetValue(i));
            }
            Console.Write("điểm trung bình các môn: ");
            Console.WriteLine(trungbinh(diem));
            Console.Write("điểm cao nhất: ");
            Console.WriteLine(max(diem));
            Console.Write("điểm thấp nhất: ");
            Console.WriteLine(min(diem));



        }
        static double trungbinh(Array ar)
        {
            double tong = 0;
            for (int i = ar.GetLowerBound(0); i < ar.GetUpperBound(0) + 1; i++) 
            {
                
                tong = tong + Convert.ToDouble(ar.GetValue(i));
            }
            double trung_binh = tong/(ar.GetUpperBound(0)+1);
            return trung_binh;

        }
        static double min(Array ar)
        {
            double min = 10;
            for (int i = ar.GetLowerBound(0); i < ar.GetUpperBound(0) + 1; i++)
            {
                
                if (Convert.ToDouble(ar.GetValue(i)) < min)
                    min = Convert.ToDouble(ar.GetValue(i));
            }
            return min;            
        }
        static double max(Array ar)
        {
            double max = 0;
            for (int i = ar.GetLowerBound(0); i < ar.GetUpperBound(0) + 1; i++)
            {

                if (Convert.ToDouble(ar.GetValue(i)) > max)
                    max = Convert.ToDouble(ar.GetValue(i));
            }
            return max;
        }
        
    }
}
