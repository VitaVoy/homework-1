using System;

namespace homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свою Фамилию");
            string Surname = Console.ReadLine();
            Console.WriteLine("Введите свое Имя");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите свое Отчество");
            string Otchestvo = Console.ReadLine();
            Console.WriteLine("Введите свой рост");
            string Height = Console.ReadLine();
            Console.WriteLine("Введите свой вес");
            string Weight = Console.ReadLine();
            Console.WriteLine(Surname + " " + Name + " " + Otchestvo + " " + Height + " " + Weight); // Метод склеивания

            // Console.WriteLine("{0} {1} {2} {3} {4}", Surname, Name, Otchestvo, Height, Weight); // Форматированный вывод

            // Console.WriteLine($"{Surname} {Name} {Otchestvo} {Height} {Weight}"); // Вывод со значком $
        }
    }
}
