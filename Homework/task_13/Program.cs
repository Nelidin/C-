// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//
//                                            645 -> 5
//                                            78 -> третьей цифры нет
//                                            32679 -> 6

Console.Clear();

Console.WriteLine("Введите любое число: ");
int num = int.Parse(Console.ReadLine()!);

if (num < 100)

{
    Console.WriteLine($"Третьeй цифры нет");
}

while (num >= 100)

{
    if (num < 1000)

    {
        int result = num % 10;
        Console.WriteLine($"Третья цифра = {result}");
    }

    num = num / 10;
}
