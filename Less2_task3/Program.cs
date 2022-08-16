/*Задача третья. Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и является ли этот день выходным.*/

Console.WriteLine ("Введите цифру, которая обозначет день недели: ");

int numDay = int.Parse (Console.ReadLine());

if (numDay == 6 || numDay == 7)
{Console.WriteLine ("(Выходной) - да");}

else if (numDay < 1 || numDay > 7)
{Console.WriteLine ("Такого дня не существует");}

else
{Console.WriteLine ("(Будний день) - нет");}
