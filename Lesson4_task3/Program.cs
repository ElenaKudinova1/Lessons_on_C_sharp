/* Третья задача. Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.*/

int[] nums = new int[8];

for (int i = 0; i < nums.Length; i++)
    {nums [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ");}

int Method (int arr)
{return nums[arr];}