using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceți numărătorul m si numitorul n: ");
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string rasp = TransfInZec(m, n);
        Console.WriteLine($"Rezultatul este: {rasp}");
    }

    static string TransfInZec(int numarator, int numitor)
    {
        int parteIntreaga = numarator / numitor;
        int rest = numarator % numitor;
        string parteZecimala = "";
        string perioada = "";

        if (FaraPerioada(numitor))
        {
            for (int i = 0; i < 10; i++)
            {
                rest *= 10;
                parteZecimala += (rest / numitor).ToString();
                rest %= numitor;
            }
            return $"{parteIntreaga}.{parteZecimala}";
        }
        else
        {
            while (rest != 0)
            {
                rest *= 10;
                parteZecimala += (rest / numitor).ToString();
                rest %= numitor;

                int index = parteZecimala.IndexOf((rest % numitor).ToString());
                if (index != -1)
                {
                    perioada = parteZecimala.Substring(index);
                    parteZecimala = parteZecimala.Substring(0, index);
                    break;
                }
            }
            return $"{parteIntreaga}.{parteZecimala}({perioada})";
        }
    }

    static bool FaraPerioada(int numitor)
    {
        while (numitor % 2 == 0 || numitor % 5 == 0)
        {
            if (numitor % 2 == 0) numitor /= 2;
            if (numitor % 5 == 0) numitor /= 5;
        }
        return numitor == 1;
    }
}