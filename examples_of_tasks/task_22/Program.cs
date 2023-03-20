// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

//                                          5 -> 1, 4, 9, 16, 25.
//                                          2 -> 1,4


Console.Clear();

int count = 1;
Console.Write("введте число: ");
int a = Convert.ToInt32(Console.ReadLine()!);

while (count <= a)
{
    Console.Write(count * count);

    if (count != a)

    {
        Console.Write(", ");
    }
    
    count++;
}