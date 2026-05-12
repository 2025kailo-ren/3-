using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)//15
        {
            Console.Write("Введите радиус круга: ");
            double R = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону квадрата: ");
            double a = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * R * R;
            double squareArea = a * a;
            if (circleArea > squareArea)
            Console.WriteLine("Площадь круга больше");
            else
            Console.WriteLine("Площадь квадрата больше");
        }
    }
}
