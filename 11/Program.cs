using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)//11
        {
            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Введите четвертое число: ");
            double d = double.Parse(Console.ReadLine());
            double max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            double min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            Console.WriteLine($"Наибольшее: {max}, Наименьшее: {min}");
        }
    }
}
