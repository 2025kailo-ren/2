using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Program
    {
        static void Main(string[] args)//25
        {
            Console.Write("введите 4-х значное число:");
            int num4 = int.Parse(Console.ReadLine());
            int t1 = num4 / 1000;
            int t2 = (num4 / 100) % 10;
            int t3 = (num4 / 10) % 10;
            int t4 = num4 % 10;
            Console.WriteLine(t1 + t2 + t3 + t4);
            Console.WriteLine(t1 * t2 * t3 * t4);
        }
    }
}
