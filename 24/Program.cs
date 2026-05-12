using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    class Program
    {
        static void Main(string[] args)//24
        {
            Console.Write("введите а:");
            int a6 = int.Parse(Console.ReadLine());
            int a2_1 = a6 * a6;
            int a4_1 = a2_1 * a2_1;
            int a6_1 = a2_1 * a4_1;
            int a7_1 = a6_1 * a6;
            int a8_1 = a4_1 * a4_1;
            int a9_1 = a8_1 * a6;
            int a10_1 = a8_1 * a2_1;
            Console.WriteLine(a4_1);
            Console.WriteLine(a6_1);
            Console.WriteLine(a7_1);
            Console.WriteLine(a8_1);
            Console.WriteLine(a9_1);
            Console.WriteLine(a10_1);
        }
    }
}
