using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb16
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            double d = int.Parse(Console.ReadLine());
            double e = int.Parse(Console.ReadLine());
            SortareCrescatoare(ref a, ref b);
            SortareCrescatoare(ref a, ref c);
            SortareCrescatoare(ref a, ref d);
            SortareCrescatoare(ref a, ref e);
            SortareCrescatoare(ref b, ref c);
            SortareCrescatoare(ref b, ref d);
            SortareCrescatoare(ref b, ref e);
            SortareCrescatoare(ref c, ref d);
            SortareCrescatoare(ref c, ref e);
            SortareCrescatoare(ref d, ref e);

            Console.WriteLine($"{a}, {b}, {c}, {d}, {e}");
        }
        static void SortareCrescatoare(ref double x, ref double y)
        {
            if (x > y)
            {
                double aux = x;
                x = y;
                y = aux;
            }
        }
    }
}
