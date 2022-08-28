/*Задача третья. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/

Console.Write("Введите размер строки 'a':  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите размер столбца 'b':  ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Sum(arr(a, b));

int[,] arr(int a, int b)

{
    int[,] arr = new int[a, b];

for (int i = 0; i < arr.GetLength(0); i++)

{for (int j = 0; j < arr.GetLength(1); j++)

    {arr[i, j] = new Random().Next(-25, 25);
    Console.Write(arr[i, j] + " ");}Console.WriteLine();}

    return arr;
}

void Sum(int[,] arr)

{
    Console.WriteLine();
for (int j = 0; j < arr.GetLength(1); j++)
    {double sum = 0;

for (int i = 0; i < arr.GetLength(0); i++)
    {sum += arr[i, j];}

    Console.WriteLine("Среднее арифметическое в столбце [" + (j+1) + "]  =  " + sum/arr.GetLength(0));}
}