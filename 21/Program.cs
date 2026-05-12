using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)//21
        {
            Console.Write("введите R:");
            double R = double.Parse(Console.ReadLine());
            Console.Write("введите r:");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.PI * (R * R - r * r));
        }
    }
}
