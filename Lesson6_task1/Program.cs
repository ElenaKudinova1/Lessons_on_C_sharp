/*Задача первая. Пользователь вводит с клавиатуры N чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

Console.Write("Введите количесто чисел: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] arrNums = new int[a];

void InputNumbers(int a)

{
for (int i = 0; i < a; i++)

    {Console.Write($"Ввод {i+1} числа: ");
    arrNums[i] = Convert.ToInt32(Console.ReadLine());}
}

int Comparison(int[] arrNums)

{
    int score = 0;

for (int i = 0; i < arrNums.Length; i++)

    {if(arrNums[i] > 0) score += 1;}

  return score;
} 

InputNumbers(a);

Console.WriteLine($"Чисел больше 0: {Comparison(arrNums)} ");