using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool Prim = Primalitate(n);
            if (Prim)
                Console.WriteLine("Numarul este prim");
            else
                Console.WriteLine("Numarul NU este prim");
            
        }
    
        static bool Primalitate(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            if (n <= 3)
            {
                return true;
            }

            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
