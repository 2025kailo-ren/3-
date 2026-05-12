using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)//9
        {
            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());
            double max = a > b ? a : b;
            double min = a < b ? a : b;
            Console.WriteLine($"Максимум: {max}, Минимум: {min}");
        }
    }
}
