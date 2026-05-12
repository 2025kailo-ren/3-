using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    class Program
    {
        static void Main(string[] args)//24задание
        {
    
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());

            string suit = m == 1 ? "пик" : m == 2 ? "треф" : m == 3 ? "бубен" : "черв";
            string rank = k == 6 ? "шестерка" : k == 7 ? "семерка" : k == 8 ? "восьмерка" : k == 9 ? "девятка" : k == 10 ? "десятка" : k == 11 ? "валет" : k == 12 ? "дама" : k == 13 ? "король" : "туз";

            Console.WriteLine($"{rank} {suit}");
        }
    }
}
