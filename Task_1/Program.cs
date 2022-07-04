/*
    Задача 19 
    Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
*/
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine()),
    a, s, d, f, i = 0, g = n;

while (g > 0) // Захотелось сделать проверку
{
    i++;
    g /= 10;
    // Console.WriteLine(i);
}

if (i == 5)
{
    // Console.WriteLine(n);
    a = n % 10;
    // Console.WriteLine(a);
    n = n / 10;
    s = n % 10;
    // Console.WriteLine(s);
    n = n / 100;
    d = n % 10;
    // Console.WriteLine(d);
    n = n / 10;
    f = n % 10;
    // Console.WriteLine(f);
    if (a == f && s == d) Console.WriteLine("Да оно палиндромом");
    else Console.WriteLine("О ноу оно не палиндромом");
}
else Console.WriteLine("Ты неправильно ввел число!!!");


// Console.Write("Введите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine()), i = 0, i1 = 0;

// while (n > 0) // Захотелось сделать проверку
// {
//     i++;
//     n /= 10;
//     Console.WriteLine(i);
// }
// i = 5;
// if (i == 5)
// {
//     if (Convert.ToString(n)[0] == Convert.ToString(n)[4]) i1++;
//     Console.WriteLine(i1); // проверка 
//     if (Convert.ToString(n)[1] == Convert.ToString(n)[3]) i1++;
//     Console.WriteLine(i1);
//     if (i1 == 2) Console.WriteLine("Да оно палиндромом");
//     else Console.WriteLine("О ноу оно не палиндромом");
// }
// else Console.WriteLine("Ты неправильно ввел число!!!");


/*

int n = Convert.ToInt16(Console.ReadLine()),
    a, s, d, f;
// Console.WriteLine(n);
a = n % 10;
// Console.WriteLine(a);
n = n / 10;
s = n % 10;
// Console.WriteLine(s);
n = n / 100;
d = n % 10; 
// Console.WriteLine(d);
n = n / 10;
f = n % 10; 
// Console.WriteLine(f);
if (a == f && s == d) Console.WriteLine("Да оно палиндромом");
else Console.WriteLine("О ноу оно не палиндромом");
*/