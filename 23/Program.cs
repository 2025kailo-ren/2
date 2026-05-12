using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)//23
        {
            Console.Write("введите число:");
            double ch1 = double.Parse(Console.ReadLine());
            Console.Write("введите число:");
            double ch2 = double.Parse(Console.ReadLine());
            double mod1 = Math.Abs(ch1);
            double mod2 = Math.Abs(ch2);
            Console.WriteLine((mod1 + mod2) / 2);
            Console.WriteLine(Math.Sqrt(mod1 * mod2));
        }
    }
}
