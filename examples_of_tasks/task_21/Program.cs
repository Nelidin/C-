// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
                                           
//                                             A (3,6); B (2,1) -> 5,09
//                                             A (7,-5); B (1,-1) -> 7,21

Console.Clear();

Console.WriteLine("Введите координаты x1");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты y1");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты x2");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты y2");
int y2 = int.Parse(Console.ReadLine()!);


double x = Math.Pow(x1 - x2, 2);
double y = Math.Pow(y1 - y2, 2);

double distance = Math.Sqrt(x + y);

Console.WriteLine($"Растояние между точками A и B равно {distance:f2}");