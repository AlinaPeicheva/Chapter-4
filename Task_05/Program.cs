using System;


class Program
{
    static void Main()
    {
        /*Напишете програма, която чете от конзолата две цели числа (int) и отпечатва колко числа има между тях, такива, 
        че остатъкът им от деленето на 5 да е 0. Пример: в интервала (14, 25) има 3 такива числа: 15, 20 и 25.*/

        Console.Write("Въведете първото число: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("Въведете второто число: ");
        int b = Int32.Parse(Console.ReadLine());
        int c = 0;

        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0) c++;
        }

        Console.WriteLine("{0} числа има между {1} и {2}.", c, a, b);
    }
}

