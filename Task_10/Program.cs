using System;


class Program
{
    static void Main()
    {
        /* Напишете програма, която прочита цяло число n от конзолата и отпечатва на конзолата всички числа в интервала[1…n], 
           всяко на отделен ред.*/

        Console.Write("Въведите число:");
        int p = int.Parse(Console.ReadLine());

        for (int i = 1; i <= p; i++)
        {
            Console.WriteLine(i);
        }

    }

}

