/*Доп. задча: Задайте двумерный массив со случайными числами от -10 до 10. 
Найдите сумму элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.)*/

int FillArr(int[,] arr)

{
    int sum = 0;

for (int i = 0; i < arr.GetLength(0); i++)

{for (int j = 0; j < arr.GetLength(1); j++)
    {arr[i, j] = new Random().Next(-10, 11);
    Console.Write(arr[i, j] + " ");

if (i==j) sum=sum+arr[i, j];}
    Console.WriteLine();}

return sum;
}

Console.Write("Введите кол-во строк 'a':  ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите кол-во столбцов 'b':  ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine();

int [,] arr = new int[a,b] ;
Console.WriteLine(FillArr(arr));
