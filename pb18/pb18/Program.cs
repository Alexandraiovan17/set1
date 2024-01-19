using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 2; i<=n; i++)
            {  int ok = 0;
                while(n%i==0)
                {
                    n /= i;
                     ok++;
                }
                if (ok > 0)
                {
                    Console.Write(i);
                    if (ok >= 1)
                    {
                        Console.Write($"^{ok}");
                    }

                    if (n != 1)
                    {
                        Console.Write("*");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
