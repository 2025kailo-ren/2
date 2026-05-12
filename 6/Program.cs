using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args) //6
        {   float a1 = 3.2f;
            decimal b1 = 2.6m;
            double c1 = 4.5;
            c1 = (double)a1 + (double)b1 + c1;
            Console.WriteLine(c1);

        }
    }
}
