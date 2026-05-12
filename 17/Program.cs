using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)//17
        {
            Console.Write("Введите массу:");
            double mass = double.Parse(Console.ReadLine());
            Console.Write("Введите обьем:");
            double V = double.Parse(Console.ReadLine());
            Console.WriteLine(mass / V);
        }
    }
}
