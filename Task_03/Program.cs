using System;


class Program
{
    static void Main()
    {
        //Дадена фирма има име, адрес, телефонен номер, факс номер, уеб сайт и мениджър. Мениджърът има име, фамилия и телефонен номер.
        // Напишете програма, която чете информацията за фирмата и нейния мениджър и я отпечатва след това на конзолата.

        Console.Write("Въведете вашето име: ");
        string Name = Console.ReadLine();

        Console.Write("Адрес: ");
        string address = Console.ReadLine();

        Console.Write("Телефонен номер: ");
        string phoneNum = Console.ReadLine();

        Console.Write("Факс номер: ");
        string fax = Console.ReadLine();

        Console.Write("Уеб сайт: ");
        string webSite = Console.ReadLine();

        Console.Write("Mениджър: ");
        string m = Console.ReadLine();

        Console.Write("Името на мениджъра: ");
        string mName = Console.ReadLine();

        Console.Write("Фамилия на мениджъра: ");
        string mLast = Console.ReadLine();

        Console.Write("Телефонен номер на мениджъра: ");
        string mPhone = Console.ReadLine();

        Console.WriteLine("\nFirm's:\n Name {0}\n Address: {1}\n Phone number: {2}\n Fax: {3}\n Web Site: {4}\n Manager: {5}", Name, address, phoneNum, fax, webSite, m);
        Console.WriteLine("\n\n Manager's:\n First name {0}\n Last name: {1}\n Phone number: {2}", mName, mLast, mPhone);
    }
}


