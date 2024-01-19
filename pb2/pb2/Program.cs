using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            double x1 = 0, x2 = 0, x, d = 0;
            d = b * b - 4 * a * c;

            if (a == 0)
                if (b == 0)
                    if (c == 0)
                        Console.WriteLine("Ecuatie nedeterminata");
                    else
                        Console.WriteLine("Ecuatie imposibila");
                else
                {
                    if (d < 0)
                    {
                       // Console.WriteLine($"x1={-b / (2 * a)}+{Math.Sqrt(-((b * b) - (4 * a * c))) / (2 * a)}i; x2 = {-b / (2 * a)}-{(Math.Sqrt(-d)) / (2 * a)}i");
                        Console.WriteLine("Radacinile sunt complexe");
                    }
                    if (d > 0)
                    {
                        x1 = (-b + Math.Sqrt(d)) / (2 * a);
                        x2 = (-b - Math.Sqrt(d)) / (2 * a);
                        Console.WriteLine(x1);
                        Console.WriteLine(x2);
                    }

                    if (d == 0)
                    {
                        x = ((-b) / 2 * a);
                        Console.WriteLine(x);
                    }
                }
        }
    }
}
