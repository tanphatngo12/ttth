﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("so a la {0}, so b la {1}",a,b);
            Console.ReadLine();
        }
    }
}
