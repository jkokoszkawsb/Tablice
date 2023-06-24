using System;

public class MyProgram
{
    private static Random random = new Random();

    public static void Main(string[] args)
    {
        int[] tablica = new int[10];
        int i;
        Console.WriteLine("to jest normlana tablica");
        for (i = 0; i <= 9; i++)
        {
            tablica[i] = random.Next(100);
            Console.WriteLine(tablica[i]);
        }
        Console.WriteLine("to jest odwrócona tablica");
        for (i = 9; i >= 0; i--)
        {
            Console.WriteLine(tablica[i]);
        }
        Console.ReadLine();
    }
}
