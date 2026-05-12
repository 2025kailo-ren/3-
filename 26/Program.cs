using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    class Program//26
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n26 = int.Parse(Console.ReadLine());
            string[] months = { "янв", "фев", "мар", "апр", "май", "июн", "июл", "авг", "сен", "окт", "ноя", "дек" };
            Console.WriteLine(months[(1 + n26) % 12 == 0 ? 11 : (1 + n26) % 12 - 1]);
        }
    }
}
