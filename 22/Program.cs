using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)//22
        {
            Console.Write("введите а:");
            double ka1 = double.Parse(Console.ReadLine());
            Console.Write("введите b:");
            double ka2 = double.Parse(Console.ReadLine());
            double gip = Math.Sqrt(ka1 * ka1 + ka2 * ka2);
            Console.WriteLine(ka1 + ka2 + gip);
        }
    }
}
