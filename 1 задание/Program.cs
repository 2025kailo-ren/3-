using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_задание
{
    class Program
    {
        static void Main(string[] args) //1задание
        {
            Console.Write("Введите значение А (true/false): ");
            bool A = bool.Parse(Console.ReadLine());

            Console.Write("Введите значение B (true/false): ");
            bool B = bool.Parse(Console.ReadLine());

            bool C = !(!A && !B) && A;
            Console.WriteLine($"не (не {A} и не {B}) и {A} = {C}");
        }
    }
}
