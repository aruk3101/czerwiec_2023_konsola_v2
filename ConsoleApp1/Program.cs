using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Liczby pierwsze od 2 do 100: " + string.Join(", ", SitoEratostenesa(100)));
        }

        static List<int> SitoEratostenesa(int n)
        {
            bool[] A = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                A[i] = true;
            }

            return null;
        }
    }
}
