/*Первая задача. Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.**/

Console.Write("Введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());
int i = 0;

int[] a = new int[size];
Random Ran = new Random();

int score = 0;

Console.Write("Массив:  ");

for (i = 0; i < size; i++)

    {a[i] = Ran.Next(100, 1000);
    if (a[i] % 2 == 0)
    score++;
    Console.Write($"{a[i]} ");}

Console.WriteLine();
Console.Write("Количество чётных чисел в массиве = " + score);
