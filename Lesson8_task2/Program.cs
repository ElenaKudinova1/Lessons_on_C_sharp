/*Задача вторая. Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Программа считает сумму элементов в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов*/

Console.Write("Введите размер строки 'a': ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите размер столбца 'b': ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] arr = new int[a, b];

int[,] FillArr(int[,] arr)

{
for (int i = 0; i < arr.GetLength(0); i++)

{for (int j = 0; j < arr.GetLength(1); j++)

    {arr[i, j] = new Random().Next(0, 15);
    Console.Write(arr[i, j] + " ");}

    Console.WriteLine();}

return arr;
}

void MinString(int[,] arr)

{
    Console.WriteLine();

    int score = 0;
    double min = 111;
    double sum = 0;

for (int i = 0; i < arr.GetLength(0); i++)

{for (int j = 0; j < arr.GetLength(1); j++)

     {sum += arr[i, j];}

if (sum < min)

    {min = sum;
    score = i;
    sum = 0;}}

System.Console.WriteLine("Строка с наименьшей суммой чисел: " + (score + 1));
}

FillArr(arr);
MinString(arr);