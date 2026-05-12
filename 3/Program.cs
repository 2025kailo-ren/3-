using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)//3
        {
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите число y: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Введите число z: ");
            double z = double.Parse(Console.ReadLine());

            bool result = (x != 0 || y != 0) ? (z == x) : true;
            Console.WriteLine($"(x ∨ y) -> (z ≡ x) = {result}");
        }
    }
}
