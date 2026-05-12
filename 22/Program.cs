using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)//22
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d=");
            int d = int.Parse(Console.ReadLine());

            int f1 = (a / c) * (b / d);
            int f2 = (a / d) * (b / c);

            Console.WriteLine(f1 >f2 ? "вдоль длинной" : f2 > f1 ? "вдоль короткой" : "одинаково");
        }
    }
}
