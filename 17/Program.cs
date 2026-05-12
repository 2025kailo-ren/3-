using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)//17задание
        {
            Console.Write("Введите x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите ширину 1 прямоугольника: ");
            double w1 = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту 1 прямоугольника: ");
            double h1 = double.Parse(Console.ReadLine());
            Console.Write("Введите x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите y2: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("Введите ширину 2 прямоугольника: ");
            double w2 = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту 2 прямоугольника: ");
            double h2 = double.Parse(Console.ReadLine());
            double x1_прав = x1 + w1;
            double y1_лев = y1 + h1;
            double x2_прав = x2 + w2;
            double y2_лев = y2 + h2;
            bool a = x1 >= x2 && y1 >= y2 && x1_прав <= x2_прав && y1_лев <= y2_лев;
            bool b = a || (x2 >= x1 && y2 >= y1 && x2_прав <= x1_прав && y2_лев <= y1_лев);
            bool c = !(x1_прав <= x2 || x2_прав <= x1 || y1_лев <= y2 || y2_лев <= y1);
            Console.WriteLine($"а) {a}");
            Console.WriteLine($"б) {b}");
            Console.WriteLine($"в) {c}");
        }
    }
}
