using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {

        static void Main(string[] args) //5 задание, в "а" лучше вводить число которое будет меньше "b" а то ничего не заработает
        {
            Random rnd = new Random();
            Console.Write("введите а:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("введите b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(rnd.Next(a, b));
        }
    }
}
