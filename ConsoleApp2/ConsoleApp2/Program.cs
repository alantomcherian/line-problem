﻿using System;

namespace ConsoleApp2
{
    class Program
    {/// <summary>
     /// 
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("enter coordinates of line1 (x1) ::");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter coordinates of line1 (y1) ::");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter coordinates of line1 (x2) ::");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter coordinates of line1 (y2) ::");
            int y2 = int.Parse(Console.ReadLine());
            int a = (int)Math.Pow(x2 - x1,2);
            int b = (int)Math.Pow(y2 - y1, 2);
            float l1 = (float)Math.Sqrt(a + b);
            Console.WriteLine(l1);

            Console.WriteLine("enter coordinates of line2 (x3) ::");
            int x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter coordinates of line2 (y3) ::");
            int y3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter coordinates of line2 (x4) ::");
            int x4 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter coordinates of line2 (y4) ::");
            int y4 = int.Parse(Console.ReadLine());
            int c = (int)Math.Pow(x4 - x3, 2);
            int d = (int)Math.Pow(y4 - y3, 2);
            float l2 = (float)Math.Sqrt(c + d);
            Console.WriteLine(l2);

            if (l1 == l2)
            {
                Console.WriteLine("both lines are equal");
            }
            else if (l1 > l2)
            {
                Console.WriteLine("l1 is greater than l2");
            }
            else
            {
                Console.WriteLine("l1 is lesser than l2");
            }
        }
    }
}
