/*Задача вторая. Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.*/

Console.WriteLine ("Введите число: ");

int num = int.Parse (Console.ReadLine());
string threeNum = Convert.ToString (num);

if  (threeNum.Length > 2)
{Console.WriteLine ("Третья цифра: " + threeNum[2]);}

else
{Console.WriteLine ("Третьей цифры нет!");}