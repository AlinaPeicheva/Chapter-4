using System;


class Program
{
    static void Main()
    {
        //Напишете програма, която пресмята сумата(с точност до 0.001): 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5 + ...

        Console.Write("Въведете последното число: ");
        int num = int.Parse(Console.ReadLine());
        double sum = 1.0;

        for (int i = 2; i <= num; i++)
        {
            sum += (1.0 / i);
        }
        Console.WriteLine("{0:F3}", sum);
    }
}

