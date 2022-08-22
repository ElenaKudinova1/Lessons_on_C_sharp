/*Третья задача. Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.*/

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] aR = new double[size];

Console.Write("Наш массив: ");

for (int i = 0; i < aR.Length; i++ )

    {aR[i] = new Random().Next(0, 21);
    Console.Write(aR[i] + " ");}

double maxNum = aR[0];
double minNum = aR[0];

for (int i = 1; i < aR.Length; i++)

    {if (maxNum < aR[i])
    {maxNum = aR[i];}
    if (minNum > aR[i])
    {minNum = aR[i];}}

double decision = maxNum - minNum;

Console.WriteLine();
Console.WriteLine("Разница между минимальным -> " + minNum +
" и максимальным -> " + maxNum + " = " + decision);