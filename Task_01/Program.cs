using System;


class Program
{
    static void Main()
    {
        // Напишете програма, която чете от конзолата три числа от тип int и отпечатва тяхната сума.

        Console.Write("Въведете первото число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Въведете второто число: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Въведете третето число: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Сумата на трите числа е: {0}", a + b + c);
    }
}

