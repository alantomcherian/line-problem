using System;

namespace ConsoleApp2
{
    class Program
    {/// <summary>
     /// 
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("enter coordinates of line (x1) ::");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter coordinates of line (y1) ::");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter coordinates of line (x2) ::");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter coordinates of line (y2) ::");
            int y2 = Convert.ToInt32(Console.ReadLine());
            float l1 = (float)Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine(l1);
        }
    }
}
