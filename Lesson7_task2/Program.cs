/*Задача вторая. Напишите программу, которая на вход принимает число, 
и возвращает индексы этого элемента или же указание, что такого элемента нет.*/

Console.Write("введите номер строки: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("введите номер столбца: ");
int b = Convert.ToInt32(Console.ReadLine());

int [,] nums = new int [3,5];

ArrRandomNums(nums);

if (a > nums.GetLength(0) || b > nums.GetLength(1))
{Console.WriteLine("Такого элемента нет!");}

else
{Console.WriteLine($"Значение элемента СТРОКИ {a} и СТОЛБЦА {b} = {nums[a-1, b-1]}");}

PrintArr(nums);

void ArrRandomNums(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)

    {for (int j = 0; j < arr.GetLength(1); j++)
        {arr [i,j] = new Random().Next(-500, 500)/10;}}
}

void PrintArr(int[,] arr)

{
    for (int i = 0; i < arr.GetLength(0); i++)
    {Console.Write("[ ");

    for (int j = 0; j < arr.GetLength(1); j++)
        {Console.Write(arr[i,j] + " ");}   

        Console.Write("]");
        Console.WriteLine("");}
}