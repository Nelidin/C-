// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
                                                
//                                                 456 -> 6
//                                                 782 -> 2
//                                                 918 -> 8


Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int x = int.Parse(Console.ReadLine()!);
int b = x % 10;
Console.WriteLine(b);