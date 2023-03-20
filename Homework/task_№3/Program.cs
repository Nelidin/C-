// Показать кубы чисел, заканчивающихся на четную цифру


Console.Clear();

int N = new Random().Next(1, 50);
Console.WriteLine($"N = {N}");
int number = 1;

while (number <= N)
{
    int cube = number * number * number;

    if (cube % 2 == 0)

    {
        Console.Write($"{cube}, ");
    }

    number++;
}