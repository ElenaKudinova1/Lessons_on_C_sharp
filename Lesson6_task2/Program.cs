/*Задача 43: Напишите программу, которая найдёт точку пересечения 
двух прямых, y = k1 * x + b1, y = k2 * x + b2; значения 
b1, k1, b2 и k2 задаются пользователем.*/

Console.WriteLine("Введите первую координату (b1)");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите первую координату (k1)");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату (b2)");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату (k2)");
double k2 = double.Parse(Console.ReadLine());

double q = (-b2 + b1)/(-k1 + k2);
double w = k2 * q + b2;

Console.WriteLine($"Две прямые пересекутся в точке Q: {q}; W: {w}");