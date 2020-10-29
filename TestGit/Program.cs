using System;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя и фамилию:");
            (string name, string surname) person;
            Console.Write("Введите имя:"); person.name = Console.ReadLine();
            Console.Write("Введите фамилию:"); person.surname = Console.ReadLine();
            Console.WriteLine($"Привет {person.name} {person.surname}!");
        }
    }
}
