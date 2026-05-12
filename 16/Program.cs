using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)//16
        {
            Console.Write("Введите число:");
            double d1 = double.Parse(Console.ReadLine());
            Console.Write("Введите число:");
            double d2 = double.Parse(Console.ReadLine());
            Console.WriteLine((d1 + d2) / 2);
            Console.WriteLine(Math.Sqrt(d1 * d2));
        }
    }
}
