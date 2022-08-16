/*Задача вторая. Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D пространстве.*/

Console.WriteLine ("Введите координаты певой точки");

Console.Write ("x = ");
double xA = int.Parse (Console.ReadLine());

Console.Write ("y = ");
double yA = int.Parse (Console.ReadLine());

Console.Write("z = ");
double zA = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите координаты второй точки");

Console.Write ("x = ");
double xB = int.Parse (Console.ReadLine());

Console.Write("y = ");
double yB = int.Parse (Console.ReadLine());

Console.Write("z = ");
double zB = int.Parse (Console.ReadLine());

double AB = Math.Sqrt (Math.Pow (xB-xA, 2) + 
                       Math.Pow (yB-yA, 2) + 
                       Math.Pow (zB-zA, 2));

Console.WriteLine ("Расстояние между точками = " + AB);