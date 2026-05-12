using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)//18задание
        {
            Console.Write("Номер года: ");
            int year = int.Parse(Console.ReadLine());
            bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            if (isLeap)
            Console.WriteLine("Год високосный");
            else
            Console.WriteLine("Год не високосный");
        }
    }
}
