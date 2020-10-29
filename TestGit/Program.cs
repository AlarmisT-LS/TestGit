using System;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя и фамилию:");
            (string name, string surname, int age) person;
            Console.Write("Введите имя:"); person.name = Console.ReadLine();
            Console.Write("Введите фамилию:"); person.surname = Console.ReadLine();
            Console.WriteLine($"Привет {person.name} {person.surname}!");
            Console.WriteLine($"Сколько тебе лет {person.name}?");
            Console.Write("Возраст:"); person.age = int.Parse(Console.ReadLine());
        }
    }
}
