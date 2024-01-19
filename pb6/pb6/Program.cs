using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b)
            {
                Console.WriteLine("DA");
            }
            else
                Console.WriteLine("NU");
        }
    }
}
