// Задача 21: Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координату x точки A: ");
double x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y точки A: ");
double y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату z точки A: ");
double z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x точки B: ");
double x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y точки B: ");
double y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату z точки B: ");
double z2 = int.Parse(Console.ReadLine());

double d = (x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1);
double c = Math.Sqrt(d);
Console.WriteLine($"Расстояние между двумя точками = {Math.Round(c, 2)}"); // <Math.Round(a, 2)> - округление после запятой

