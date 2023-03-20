// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int result = 1;

for (int i = 1; i <= N; i++)
{
    result = result * i;
}
Console.WriteLine($"произведение чисел = {result}");