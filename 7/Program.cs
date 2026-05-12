using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)//7 
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            double y;
            if (x > 0)
            y = Math.Sin(x);
            else
            y = Math.Cos(x);
            Console.WriteLine($"y = {y}");
        }
    }
}
