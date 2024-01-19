using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//euclid
namespace pb17
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int x1 = x, y1 = y;
            while (x != y)
            {
                if (x > y)
                    x -= y;
                else
                    y -= x;
            }
            Console.WriteLine("Cmmdc este "+x);
            Console.Write("Cmmm este ");
            Console.WriteLine((x1*y1)/x);
        }
            
        }
    }

