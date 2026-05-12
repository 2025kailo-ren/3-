using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)//12
        {
            Console.Write("Введите расстояние в км: ");
            double km = double.Parse(Console.ReadLine());
            Console.Write("Введите расстояние в футах: ");
            double ft = double.Parse(Console.ReadLine());
            double kmFromFt = ft * 0.0003048;
            if (km < kmFromFt)
            Console.WriteLine("Расстояние в км меньше");
            else
            Console.WriteLine("Расстояние в футах меньше");
        }
    }
}
