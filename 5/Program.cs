using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)//5
        {
            Console.Write("Введите число A: ");
            double A = double.Parse(Console.ReadLine());

            Console.Write("Введите число B: ");
            double B = double.Parse(Console.ReadLine());

            bool D = A > 100 && B > 100;
            Console.WriteLine($"каждое из чисел А и В больше 100: {D}");
        }
    }
}
