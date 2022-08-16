/* Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N (надюсь, включительно,
т к сделала так).*/

Console.WriteLine("Введите число N: ");
int N = int.Parse (Console.ReadLine()); 
int count = 2;

Console.WriteLine("Чётные числа от 1 до N: ");

while (count <= N)
{Console.WriteLine(count);
count += 2;}