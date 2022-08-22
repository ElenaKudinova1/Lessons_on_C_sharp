/*Задача первая. Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.*/

Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());

int score = a;

for (int i = 1; i < b; i++)
    {score = score * a;}

Console.Write("A в степени B будет = " + score);
