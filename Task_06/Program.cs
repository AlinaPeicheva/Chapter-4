using System;


class Program
{
    static void Main()
    {
        // Напишете програма, която чете две числа от конзолата и отпечатвa по-голямото от тях.
        // Решете задачата без да използвате условни конструкции.

        Console.Write("Въведете първото число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Въведете второто число: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("По-голямото число е: ");
        Console.WriteLine(Math.Max(a, b));
    }
}

