// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
Console.Clear();
Console.WriteLine("Введите 5-х значное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 10000 || number > 99999)
{
    Console.WriteLine("Число введено не верно. Введите 5-и значное число!!!");
    return;
}
int number1 = number / 10000;
int number5 = number % 10;
if (number1 == number5)
{
    int number2 = number / 1000 % 10;
    int number4 = number / 10 % 10;
    if (number2 == number4)
    {
        Console.WriteLine($"Число {number} являеться палиндромом");
    }
}
else Console.WriteLine($"Число {number} не являеться палиндромом");
