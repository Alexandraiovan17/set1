using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int nr = 0, i = a;
            do
            {
                if (i % n == 0)
                {
                    nr++;
                }
                i++;
            } while (i <= b);
            Console.WriteLine(nr + " numere");
        }
    }
}
