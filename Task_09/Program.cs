using System;

class Program
{
    static void Main()
    {
       // Напишете програма, която прочита едно цяло число n от конзолата. 
       // След това прочита още n на брой числа от конзолата и отпечатва тяхната сума.

        int sum = 0;

        Console.Write("Въведете числовата стойност: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Въведете {0} число: ", i + 1);
            sum += int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Cумата на всички числа {0}.", sum);
    }
}

