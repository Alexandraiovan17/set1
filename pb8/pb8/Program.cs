using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Swap(ref a, ref b);
            Console.WriteLine( "a= "+a);
            Console.WriteLine("b= " +b);
            
        }
          static void Swap(ref int a, ref int b)
        {
            int tempswap = a;
            a = b;
            b = tempswap;


        }
    }
}
