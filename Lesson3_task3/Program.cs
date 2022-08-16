/*Задача третья. Напишите программу, которая принимает на вход число
 (N) и выдаёт таблицу кубов чисел от 1 до N.*/

Console.Write ("Введите число N: ");
 
int N = int.Parse (Console.ReadLine());
 
int score = 0;
 
while (score <= N)
{Console.Write (Math.Pow(score, 3) + " ");
score++;} 