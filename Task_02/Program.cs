using System;


class Program
{
    static void Main()
    {
        //Напишете програма, която чете от конзолата радиуса "r" на кръг и отпечатва неговото лице и обиколка.

        Console.Write("Въведете радиуса на кръга: ");
        double r = double.Parse(Console.ReadLine());
        double S = Math.PI * (r * r);
        double P = Math.PI * (2 * r);
        Console.WriteLine("Лицето на кръга е: {0}\nОбиколката на кръга е: {1}", S, P);

    }
}

