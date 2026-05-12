using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)//2задание
        {
            Console.Write("Введите значение X (true/false): ");
            bool X = bool.Parse(Console.ReadLine());

            Console.Write("Введите значение Y (true/false): ");
            bool Y = bool.Parse(Console.ReadLine());

            bool result = (X || Y) ? (Y == X) : true;
            Console.WriteLine($"(x ∨ y) -> (у ≡ x) = {result}");
        }
    }
}
