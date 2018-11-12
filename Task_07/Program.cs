using System;


class Program
{
    static void Main()
    {
        // Напишете програма, която чете пет числа и отпечатва тяхната сума. При невалидно въведено число да се 
        // подкани потребителя да въведе друго число.

        double x, sum = 0, max = 0;
        int count = 5;
        bool isTrue;

        do
        {
            Console.Write("Въведете реално число = ");
            isTrue = double.TryParse(Console.ReadLine(), out x);
            if (isTrue)
            {
                sum += x;
                max = (max < x || count == 5 ? x : max);
                count--;
            }
            else
                Console.WriteLine("Невалидно число. Въведете отново!");
        }
        while (count > 0);

        Console.WriteLine("Sum = " + sum);

    }
}

