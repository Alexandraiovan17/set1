using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb9
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
             for (int i = 1; i <= n; i++)
            {
                if(n%i==0)
                    Console.WriteLine(i);
            }
        }
            
    }
}

