using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)//13
        {
            Console.Write("Введите скорость в км/ч: ");
            double kmh = double.Parse(Console.ReadLine());
            Console.Write("Введите скорость в м/с: ");
            double ms = double.Parse(Console.ReadLine());
            double kmhFromMs = ms * 3.6;
            if (kmh > kmhFromMs)
            Console.WriteLine("Скорость в км/ч больше");
            else
            Console.WriteLine("Скорость в м/с больше");
        }
    }
}
