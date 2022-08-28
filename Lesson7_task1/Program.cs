/*Задача первая. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.*/

void A(int m, int n)

{
    double[,] arr = new double[m, n];
for (int i = 0; i < arr.GetLength(0); i++)

{for (int j = 0; j < arr.GetLength(1); j++)

    {arr[i, j] = new Random().Next(-10, 11) + new Random().NextDouble();
    Console.Write(arr[i, j] + " ");}
    
    Console.WriteLine();}
}

Console.WriteLine("Введите кол-во строк 'm' -  ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите колво столбцов 'n' -  ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

A(m, n);