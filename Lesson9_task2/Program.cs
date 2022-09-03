/*Задача вторая. Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.*/

int M = nums("Введите значение M: ");
int N = nums("Введите значение N: ");
int temp = M;

if (M > N) 

{
  M = N; 
  N = temp;
}

PrintSum(M, N, temp=0);

void PrintSum(int M, int N, int sum)
{
  sum = sum + N;

if (N <= M)

{Console.Write($"Сумма элементов = {sum}");

return;}

PrintSum(M, N - 1, sum);
}

int nums(string input) 

{
  Console.Write(input);
  int print = int.Parse(Console.ReadLine());

return print;
}