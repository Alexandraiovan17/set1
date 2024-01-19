
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool testing = DouaCifreDiferite(n);
            if(testing)
            {
                Console.WriteLine("da");
            }
            else
            {
                Console.WriteLine("nu");
            }
            
        }
        static bool DouaCifreDiferite(int n)
        {
     
            int a = n % 10;
           
            do
            {
                n /= 10;

            } while (n % 10 == a);

              int b= n % 10;
            n /= 10;
            while(n!=0)
            {
                
                int c = n % 10;
                if (c != a && c != b)
                {
                    return false;
                }
                n /= 10;
            }
            return true;
        }
    }
}
