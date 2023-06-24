using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class zad4
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[10] { 200, 47, 50, 14, 46, 57, 324, 56, -5, 43 };
            int l = tablica.Length;

            Console.WriteLine("tablica przed posortowanie");
            foreach (int i in tablica)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i < l; ++i)
            {
                int aktualna = tablica[i];
                int j = i - 1;

                while (j >= 0 && tablica[j] > aktualna)
                {
                    tablica[j + 1] = tablica[j];
                    j = j - 1;
                }

                tablica[j + 1] = aktualna;
            }

            Console.WriteLine("tablica po posortowaniu");
            foreach (int i in tablica)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
