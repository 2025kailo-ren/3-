using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    class Program//27 задание
    {
        static void Main(string[] args)
        {
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] d = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int pm = m, pn = n - 1;
            if (pn == 0) { pm = m - 1;
            if (pm == 0) pm = 12; pn = d[pm - 1]; }
            int nm = m, nn = n + 1;
            if (nn > d[m - 1]) { nm = m + 1;
            if (nm == 13) nm = 1; nn = 1; }
            Console.WriteLine(pn + "." + pm);
            Console.WriteLine(nn + "." + nm);
        }
    }
}
