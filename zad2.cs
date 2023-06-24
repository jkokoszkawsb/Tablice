using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class zad2
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[10] {200, 47, 50, 14, 46, 57, 324, 56, -5, 43,};
            int max,min;
            max = tablica[0];
            min = tablica[0];
            foreach (int i in tablica)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }

            Console.WriteLine("Największa Liczba z tablicy:" + max);
            Console.WriteLine("Największa Liczba z tablicy" + min);
            Console.ReadLine();
        }
    }
}
