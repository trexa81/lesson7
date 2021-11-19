using System;

namespace lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello " + name);
        }
    }
}
