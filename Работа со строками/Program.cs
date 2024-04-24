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
            string fullName = "Григорьев Эрнест Родригович";
            int age = 25;
            string university = "Университет Саньтьяго-де-Чили";
            string speciality = "специалист по обнаружению НЛО";
            Console.WriteLine($"Ваше полное имя: {fullName}, вам {age}, вы закончили {university} на специальность {speciality}");
        }
    }
}
