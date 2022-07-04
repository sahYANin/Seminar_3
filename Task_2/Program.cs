/*
    Задача 21 
    Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D пространстве.
*/

double x1, x2, y1, y2, z1, z2, l;

Console.WriteLine("Введите координаты точки А: ");
Console.Write("x = ");
x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("y = ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("z = ");
z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("x = ");
x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("y = ");
y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("z = ");
z2 = Convert.ToDouble(Console.ReadLine());

l = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));

Console.Write("Длинна отрезка равна = ");
Console.Write(l); 