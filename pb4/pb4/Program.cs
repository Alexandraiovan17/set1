using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if(x%4 ==0 || x%400==0)
            {
                Console.WriteLine(x+" ESTE AN BISECT");
            }
            else
                Console.WriteLine(x+ " NU ESTE AN BISECT");
        }
    }
}
