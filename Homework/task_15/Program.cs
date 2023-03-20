// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//                                  является ли этот день выходным.
//
//                                             6 -> да
//                                             7 -> да
//                                             1 -> нет

Console.Clear();

Console.WriteLine("Введите цифру, дня недели: ");
int day = int.Parse(Console.ReadLine()!);


if (day >= 1 && day <= 7)
{
    if (day >= 6)
    {
        Console.WriteLine("Это выходной день");
    }
    else
    {
        Console.WriteLine("Это рабочий день");
    }
}
else
{
    Console.WriteLine("В неделе всего 7 дней!!!");
}
