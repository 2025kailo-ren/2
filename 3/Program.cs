using System;
namespace _3
{
    class Program
    {
        static void Main(string[] args) //3 по 4 задание
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next());
            Console.WriteLine(rnd.Next(5));
            Console.WriteLine(rnd.Next(-5,5));
        }
    }
}
