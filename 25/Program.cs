using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Program //25задание
    {
        static void Main(string[] args)
        {
            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            Console.Write("d=");
            int d = int.Parse(Console.ReadLine());
            int n = (k + d - 2) % 7;
            if (n == 0) Console.WriteLine("понедельник");
            if (n == 1) Console.WriteLine("вторник");
            if (n == 2) Console.WriteLine("среда");
            if (n == 3) Console.WriteLine("четверг");
            if (n == 4) Console.WriteLine("пятница");
            if (n == 5) Console.WriteLine("суббота");
            if (n == 6) Console.WriteLine("воскресенье");
        }
    }
}
