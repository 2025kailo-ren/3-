using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)//4
        {
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите число y: ");
            double y = double.Parse(Console.ReadLine());

            bool z = x < 2 && y < 3;
            Console.WriteLine($"{x} < 2 и {y} < 3 = {z}");
        }
    }
}
