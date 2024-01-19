using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int ok = 0;
            int m = n;
            while (m > 0)
            {
                m = m / 10;
                ok++;
            }
            if (k <= ok)
            {
                while (k > 1)
                {
                    k--;
                    n = n / 10;
                }
                Console.WriteLine(n % 10);
            }

        }
    }
}
