/*Задача первая. Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.*/

Console.WriteLine ("Введите трёхзначное число: ");

int treeNums = int.Parse (Console.ReadLine());
string num = Convert.ToString (treeNums);

Console.WriteLine ("Вторая цифра данного числа: " + num[1]);
