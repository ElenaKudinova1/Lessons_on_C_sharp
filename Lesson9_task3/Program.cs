/**Задача третья. Напишите программу вычисления функции Аккермана с помощью 
рекурсии. Даны два неотрицательных числа m и n.*/

int m = InputNum("Введите положительное число m: ");
int n = InputNum("Введите положительное число n: ");

Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int InputNum(string print)
{
    Console.Write(print);

    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
if (m == 0) return n + 1;

if (m > 0 && n == 0) return Akkerman(m - 1, 1);

else return Akkerman(m - 1, Akkerman(m, n - 1));
}