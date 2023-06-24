using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class zad5
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[10] { 100, 37, 40, 4, 36, 47, 224, 46, -1, 33 };
            int l = tablica.Length;

            Console.WriteLine("tablica przed posortowanie");
            foreach (int i in tablica)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < l - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < l; j++)
                    if (tablica[j] < tablica[min])
                        min = j;

                int tymczasowa = tablica[min];
                tablica[min] = tablica[i];
                tablica[i] = tymczasowa;
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
