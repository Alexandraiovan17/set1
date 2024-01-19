using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1=0 , n2 = n;
            while(n!=0)
            {
                n1 = n1 * 10 + n % 10;
                n /= 10;
            }
            if(n1==n2)
                Console.WriteLine($"Numarul {n2} este palindrom");
            else
                Console.WriteLine($"Numarul {n2} nu este palindrom");
        }
    }
}
