using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)//16задание
        {
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            bool aDivB = b % a == 0;
            bool bDivA = a % b == 0;
            Console.WriteLine($"a является делителем b: {aDivB}");
            Console.WriteLine($"b является делителем a: {bDivA}");
        }
    }
}
