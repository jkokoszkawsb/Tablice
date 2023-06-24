using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class zad3
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[10] { 300, 57, 60, 24, 56, 67, 424, 66, -15, 53 };
            int l = tablica.Length;

            Console.WriteLine("tablica przed posortowanie");
            foreach (int i in tablica)
            {
                Console.WriteLine(i);
            }
            do
            {
                for (int i = 0; i < l - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        int tymczasowa = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = tymczasowa;
                    }
                }
                l--;
            }
            while (l > 1);

            Console.WriteLine("tablica po posortowaniu");
            foreach (int i in tablica)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
