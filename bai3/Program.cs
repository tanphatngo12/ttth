using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.WriteLine("Nhap duong kinh: ");
            int dk = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ban kinh: ");
            int bk = int.Parse(Console.ReadLine());
            double dt = (double) pi * (bk * bk);

        }
    }
}
