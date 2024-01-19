using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb13
{
    class Program
    {
        static void Main(string[] args)
        {
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int nrani = 0,i;
            for(i=y1;i<=y2;i++)
            {
                if(VerifAnBisect(i))
                {
                    nrani++;
                }
            }
            Console.WriteLine($"Intre {y1} si {y2} exista " + nrani + " ani bisecti");
        }

        static bool VerifAnBisect(int an)
        {
            return (an % 4 == 0 && an % 100 != 0) || (an % 400 == 0);
        }
    }
}
