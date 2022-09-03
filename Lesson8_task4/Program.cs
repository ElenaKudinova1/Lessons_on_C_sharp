/*Задача четвёртая. Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно выводить 
массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2*/

int[,,] arr3D = new int[2, 2, 2];

int[,,] FillArr(int[,,] arr3D)

{
for (int i = 0; i < arr3D.GetLength(0); i++)

{for (int j = 0; j < arr3D.GetLength(1); j++)

{for (int k = 0; k < arr3D.GetLength(2); k++)
{
    arr3D[i, j, k] = new Random().Next(0, 15);
    Console.Write(arr3D[i, j, k] + "(" + i + "," + j + "," + k + ") ");
}
    Console.WriteLine();}}

return arr3D;
}
Console.WriteLine("Построчный вывод массива с индексами: ");
FillArr(arr3D);