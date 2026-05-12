using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)//6
        {
            Console.Write("Введите целое число A: ");
            int A = int.Parse(Console.ReadLine());

            bool result = A % 2 == 0 || A % 3 == 0;
            Console.WriteLine($"целое А кратно двум или трем: {result}");
        }
    }
}
