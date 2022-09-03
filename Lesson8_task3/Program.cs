/*Задача третья. Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.*/

Console.Write("Введите размер строки 'a': ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите размер столбца 'b': ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] arr0 = new int[a, b];
int[,] arr1 = new int[a, b];

int[,] FillArr(int[,] arr0)

{
for (int i = 0; i < arr0.GetLength(0); i++)

{for (int j = 0; j < arr0.GetLength(1); j++)

    {arr0[i, j] = new Random().Next(0, 15);
    Console.Write(arr0[i, j] + " ");}

    Console.WriteLine();}

return arr0;
}

void Produkt(int[,] arr0, int[,] arr1)

{
int[,] matrix = new int[arr0.GetLength(0), arr0.GetLength(1)];

for (int i = 0; i < arr0.GetLength(0); i++)
    
{for (int j = 0; j < arr0.GetLength(1); j++)

    {matrix[i, j] = arr0[i,j] * arr1[i,j];
    System.Console.Write(matrix[i, j] + " ");}

    System.Console.WriteLine();}
}

System.Console.WriteLine("Первый массив: ");
FillArr(arr0);
System.Console.WriteLine();

System.Console.WriteLine("Второй массив: ");
FillArr(arr1);
System.Console.WriteLine();

System.Console.WriteLine("Произведение массивов = ");

Produkt(arr0, arr1);