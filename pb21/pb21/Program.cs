using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alegeti un numar intre 1 si 1024. Raspundeti cu 'da' sau 'nu'. "); 

            int min = 1 , max=1024, incercare =0;

            while(true)
                {
                if (min == max)
                {
                    incercare = min;
                    break;
                }
                if ((max - min) % 2 == 0)
                {
                    incercare = (min + max) / 2;
                }
                else
                {
                    incercare = (min + max+ 1) / 2;
                }

               

                Console.Write($"Numărul dumneavoastră este mai mare sau egal decât {incercare}? (da/nu): ");
                string raspuns = Console.ReadLine();
                if (raspuns.Equals("da",StringComparison.OrdinalIgnoreCase))
                {
                    min = incercare;
                }
                if(raspuns.Equals("nu",StringComparison.OrdinalIgnoreCase))
                {
                    max = incercare - 1;
                }
              }
            Console.WriteLine($"Numărul dumneavoastră este {incercare}!");
        }
    }
}
