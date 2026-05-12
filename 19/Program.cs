using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)//19
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int maxCount = 0;
            int temp;
            temp = (a / c) * (b / d);
            if (temp > maxCount) maxCount = temp;
            temp = (a / d) * (b / c);
            if (temp > maxCount) maxCount = temp;
            temp = (a / c) * (b / e);
            if (temp > maxCount) maxCount = temp;
            temp = (a / e) * (b / c);
            if (temp > maxCount) maxCount = temp;
            temp = (a / d) * (b / e);
            if (temp > maxCount) maxCount = temp;
            temp = (a / e) * (b / d);
            if (temp > maxCount) maxCount = temp;
            Console.WriteLine(maxCount);
        }
    }
}
