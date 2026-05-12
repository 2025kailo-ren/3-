using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)//21
        {
            Console.Write("Введите время в минутах: ");
            double t = double.Parse(Console.ReadLine());
            double cycleTime = t % 5;
            if (cycleTime < 3)
            Console.WriteLine("Зеленый");
            else
            Console.WriteLine("Красный");
        }
    }
}
