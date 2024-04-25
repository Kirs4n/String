using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_со_строками
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            Console.Write("Введите ваше полное имя: ");
            fullName= Console.ReadLine();
            int age;
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            string university;
            Console.Write("Введите какой университет вы закончили: ");
            university = Console.ReadLine();
            string speciality;
            Console.Write("Введите на какую специальность вы учились в университете: ");
            speciality = Console.ReadLine();
            int workExperience;
            Console.Write("Введите ваш стаж работы по специальности: ");
            workExperience= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваше полное имя: {fullName}, вам: {age} лет, вы закончили {university} на специальность {speciality}, ваш стаж работы по специальности {workExperience} лет");
        }
    }
}
