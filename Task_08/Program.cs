using System;


class Program
{
    static void Main()
    {
        //Напишете програма, която чете пет числа от конзолата и отпечатва най - голямото от тях.

        Console.Write("Въведете первото число:");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("Въведете второто число:");
        int b = Int32.Parse(Console.ReadLine());
        Console.Write("Въведете третето число:");
        int c = Int32.Parse(Console.ReadLine());
        Console.Write("Въведете четвертото число:");
        int d = Int32.Parse(Console.ReadLine());
        Console.Write("Въведете петото число:");
        int e = Int32.Parse(Console.ReadLine());

             if (a > b && a > c && a > d && a > e) Console.WriteLine("{0} най-голямото.", a);
        else if (b > a && b > c && b > d && b > e) Console.WriteLine("{0} най-голямото.", b);
        else if (c > a && c > b && c > d && c > e) Console.WriteLine("{0} най-голямото.", c);
        else if (d > a && d > b && d > c && d > e) Console.WriteLine("{0} най-голямото.", d);
        else if (e > a && e > b && e > c && e > d) Console.WriteLine("{0} най-голямото.", e);
        else Console.WriteLine("Няма най-голямо число.");

    }
}

