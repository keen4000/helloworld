using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            Console.ReadLine();
        }
    }
}
