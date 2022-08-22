/*Вторая задача. Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.**/

int[] a(int length, int min = -15, int max = 15)

    {int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {result[i] = new Random().Next(min, max);}
    return result;}

int s(int[] a)  

    {int result = 0;
    for (int i = 1; i < a.Length; i += 2)
    {result += a[i];}
    return result;}

Console.Write("Введите размер массива: ");

int y = Convert.ToInt32(Console.ReadLine());
int[] array = a(y);

Console.Write("Наш массив: ");

Console.WriteLine(String.Join(", ", array));

Console.Write("Сумма элементов на нечётных позициях = ");

Console.WriteLine(s(array));
