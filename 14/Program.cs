using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)//14задание
        {
            Console.Write("Введите натуральное число: ");
            int n = int.Parse(Console.ReadLine());
            int lastDigit = n % 10;
            bool isEven = lastDigit % 2 == 0;
            bool isOdd = lastDigit % 2 != 0;
            Console.WriteLine($"Заканчивается четной цифрой: {isEven}");
            Console.WriteLine($"Заканчивается нечетной цифрой: {isOdd}");
        }
    }
}
