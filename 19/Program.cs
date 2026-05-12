using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)//19
        {
            Console.Write("введите а:");
            double a5 = double.Parse(Console.ReadLine());
            Console.Write("введите b:");
            double b5 = double.Parse(Console.ReadLine());
            Console.Write("введите c:");
            double c5 = double.Parse(Console.ReadLine());
            Console.Write("введите e:");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine((b5 * c5 + e) / a5);
        }
    }
}
