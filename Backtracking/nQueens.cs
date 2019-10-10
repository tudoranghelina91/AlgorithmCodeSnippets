using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regine
{
    class Program
    {
        static int n = 8;
        static int[] v = new int[9];
        static bool found = false;
        static int sol = 1;

        static bool Valid(int k)
        {
            for (int i = 1; i <= k-1; i++)
            {
                if (v[i] == v[k] || Math.Abs(v[k] - v[i]) == k - i)
                {
                    return false;
                }
            }

            return true;
        }

        static void Afisare()
        {
            Console.WriteLine($"Solutia {sol++}");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (v[i] == j)
                        Console.Write("R ");
                    else
                        Console.Write("_ ");
                }
                Console.WriteLine();
            }
        }

        static void Bkt(int k)
        {
            if (found)
            {
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                v[k] = i;
                if (Valid(k))
                {
                    if (k == n)
                    {
                        Afisare();
                        found = true;
                    }
                    else
                        Bkt(k + 1);
                }
            }
        }

        static void Main(string[] args)
        {
            Bkt(1);
            Console.ReadKey();
        }
    }
}
