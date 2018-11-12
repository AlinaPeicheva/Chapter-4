using System;


class Program
{
    static void Main()
    {
        //Напишете програма, която отпечатва на конзолата първите 100 числа от редицата на Фибоначи: 
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, ...

        int a = 0;
        int b = 1;
        int sum = 1;
        int count = 0;
        Console.WriteLine(a);
        while (count < 100)
        {
            sum = a + b;
            a = b;
            b = sum;
            Console.WriteLine(b);
            count++;

        }
    }
}

