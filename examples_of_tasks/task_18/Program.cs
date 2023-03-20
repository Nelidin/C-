// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек 
//                                             в этой четверти (x и y).

Console.Clear();

Console.Write("Введите четверть: ");
int a = int.Parse(Console.ReadLine()!);

// if (a == 1)
// {
//     Console.WriteLine("x > 0, y > 0");
// }
// else if (a == 2)
// {
//     Console.WriteLine("x < 0, y > 0");
// }
// else if (a == 3)
// {
//     Console.WriteLine("x < 0, y < 0");
// }
// else if (a == 4)
// {
//     Console.WriteLine("x > 0, y < 0");
// }
// else
// {
//     Console.WriteLine("Введите корректное число четверти");
// }

switch (a)
{
    case 1:
        Console.WriteLine("x > 0, y > 0");
        break;
    case 2:
        Console.WriteLine("x < 0, y > 0");
        break;
    case 3:
        Console.WriteLine("x < 0, y < 0");
        break;
    case 4:
        Console.WriteLine("x > 0, y < 0");
        break;
    default:
        Console.WriteLine("Введите корректное число четверти");
        break;
}