using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)//23задание
        {
            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            string[] cards = {"", "шестерка", "семерка", "восьмерка", "девятка", "десятка", "валет", "дама", "король", "туз" };
            Console.WriteLine(cards[k - 5]);
        }
    }
}
