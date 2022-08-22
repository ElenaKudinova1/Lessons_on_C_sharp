/*Вторая задача. Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.*/

Console.Write("Введите число: ");

int i = int.Parse(Console.ReadLine());

int sum = 0;

while (i >= 1)
      {sum += i % 10;
      i = (i - i % 10) / 10;}

Console.WriteLine("Сумма цифр в числе = " + sum);
