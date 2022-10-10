// Задача 21: Напишите программу, которая принимает на вход координаты двух
//  точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату x точки a: ");
double ax = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y точки a: ");
double ay = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x точки b: ");
double bx = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y точки b: ");
double by = int.Parse(Console.ReadLine());
// 1 
// double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by -ay, 2),2); 
// Console.WriteLine($"Расстояние между двумя точками = {Math.Round(result, 2)}"); // <Math.Round(a, 2)> - округление после запятой

//2
double d = (bx - ax)*(bx - ax) + (by - ay)*(by - ay);
double c = Math.Sqrt(d);
Console.WriteLine(c);