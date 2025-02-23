using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace B4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            ArrayList diem = new ArrayList();
            
            uint mon;
            double x;
            Console.Write("nhập số môn: ");
            string a = Console.ReadLine();
            while (!uint.TryParse(a, out mon))
            {
                Console.Write("Nhập sai, xin nhập lại: ");
                a = Console.ReadLine();
            }
            for (int i = 0; i < mon; i++)
            {
                Console.Write($"nhập điểm môn {i + 1}: ");
                string b = Console.ReadLine();
                while (!double.TryParse(b, out x) || x > 10)
                {
                    Console.Write("Nhập sai, xin nhập lại: ");
                    b = Console.ReadLine();
                }
                diem.Add(x);

            }
            int y = 1;
            foreach (object obj in diem)
            {

                Console.WriteLine($"điểm môn {y}: " + obj.ToString());
                y = y + 1;
            }

        }
        static double trungbinh(ArrayList list)
        {
            double trung_binh, tong = 0;
            foreach (object obj in list)
            {
                tong = tong + Convert.ToDouble(obj);
            }
            trung_binh = tong / list.Count;
            return trung_binh;
        }
        static double min(ArrayList list)
        {
            double min = 10;
            foreach (object obj in list)
                if (min > Convert.ToDouble(obj))
                    min = Convert.ToDouble(obj);

            return min;
        }
        static double max(ArrayList list)
        {
            double max = 0;
            foreach (object obj in list)
                if (max < Convert.ToDouble(obj))
                    max = Convert.ToDouble(obj);
            return max;
        }
    }
}

