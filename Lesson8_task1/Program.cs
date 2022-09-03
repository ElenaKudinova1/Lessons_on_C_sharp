/*Задача первая. Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

Console.WriteLine("Введите размер строки 'a':  ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите размер столбца 'b':  ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] arr = new int[a, b];


int[,] FillArray(int[,] arr)

{
for (int i = 0; i < arr.GetLength(0); i++)

{for (int j = 0; j < arr.GetLength(1); j++)

        {arr[i, j] = new Random().Next(0, 15);
        Console.Write(arr[i, j] + " ");}

        Console.WriteLine();}

return arr;
}

void Sort(int[,] arr)

{
    Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)

{for (int j = 0; j < arr.GetLength(1); j++)

    {for (int k = 0; k < arr.GetLength(1) - 1; k++)

                 {

    if (arr[i, k] <= arr[i, k + 1])

       {int a = arr[i,k];
       arr[i, k] = arr[i,k+1];
       arr[i, k+1] = a;}
}
        Console.Write(arr[i,j] + " ");}

        System.Console.WriteLine();}
}

Sort(FillArray(arr));