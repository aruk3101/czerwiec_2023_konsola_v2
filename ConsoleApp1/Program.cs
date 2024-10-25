using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Liczby pierwsze od 2 do 100: " + string.Join(", ", SitoEratostenesa(100)));
        }

        static void WypelnijTablice(bool[] tablica)
        {
            for (int i = 2; i <= Math.Sqrt(tablica.Length - 1); i++)
            {
                if (tablica[i])
                {
                    for (int j = i * 2; j <= tablica.Length - 1; j += i)
                    {
                        tablica[j] = false;
                    }
                }
            }
        }

        static List<int> SitoEratostenesa(int n)
        {
            bool[] A = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                A[i] = true;
            }

            WypelnijTablice(A);

            List<int> liczbyPierwsze = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if (A[i])
                {
                    liczbyPierwsze.Add(i);
                }
            }

            return liczbyPierwsze;
        }
    }
}
