using System;

namespace Работа_со_строками
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше полное имя: ");
            string fullName = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите какой университет вы закончили: ");
            string university = Console.ReadLine();

            Console.Write("Введите на какую специальность вы учились в университете: ");
            string speciality = Console.ReadLine();

            Console.Write("Введите ваш стаж работы по специальности: ");
            int workExperience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ваше полное имя: {fullName}, вам: {age} лет, вы закончили {university} на специальность {speciality}, ваш стаж работы по специальности {workExperience} лет");
        }
    }
}
