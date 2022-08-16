/* Напишите программу, которая на вход принимает два 
числа и выдаёт, какое число большее и какое меньшее.*/

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse (Console.ReadLine()); 

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse (Console.ReadLine());

if (number1 > number2)
{Console.WriteLine("Максимальное число: " + number1 + "." + " Минимальное число: " + number2);}

else
{Console.WriteLine("Максимальное число: " + number2 + "." + " Минимальное число: " + number1);}
