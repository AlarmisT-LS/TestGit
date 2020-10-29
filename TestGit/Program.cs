using System;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}!");
        }
    }
}
