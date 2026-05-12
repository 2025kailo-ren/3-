using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)//20задание
        {
            Console.Write("Введите номер дня (1-365): ");
            int k = int.Parse(Console.ReadLine());
            int dayOfWeek = k % 7;
            if (dayOfWeek == 6 || dayOfWeek == 0)
            Console.WriteLine("Выходной");
            else
            Console.WriteLine("Рабочий");
        }
    }
}
