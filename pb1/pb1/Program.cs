using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb1
{
    class Program
    {
        static void Main(string[] args)

        {
            float a = float.Parse(Console.ReadLine());
            float x;
            float b = float.Parse(Console.ReadLine());
            
             if (a==0)
                if(b==0)
                    Console.WriteLine("Ecuatia nedeterminata");
                     else
                        Console.WriteLine("Ecuatie imposibila");
              else
            {
                x = -b / a;
                Console.WriteLine("x=" + x);
            }
           

        }
    }
}
