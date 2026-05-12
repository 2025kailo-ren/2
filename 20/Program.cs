using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)//20
        {
            Console.Write("Введите а:");
            double katet1 = double.Parse(Console.ReadLine());
            Console.Write("Введите b:");
            double katet2 = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(katet1 * katet1 + katet2 * katet2));
        }
    }
}
