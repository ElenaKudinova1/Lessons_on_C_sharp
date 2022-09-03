/*Задача первая. Задайте значения M и N. Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N.*/

int M = 1;
int N = 25;
int NaturNum(int M, int N)

{
if (M > N && N > 0)

{return NaturNum(N,M);}

else if (M > 0 && M < N)

    {System.Console.Write(M + " ");

return NaturNum(M + 1, N);}

else

{return M;}
}

NaturNum(M, N);




