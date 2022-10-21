/*
Задача 19.
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/
/* 
bool IsNumberPalindrom(int number, int countDigit)
{
    for (int i = 1; i <= (countDigit / 2); i++)
    {
        int start = number / Convert.ToInt32(Math.Pow(10, (countDigit - i))) % 10;
        int end = number % Convert.ToInt32(Math.Pow(10, i));
        if (i > 1) end /= Convert.ToInt32(Math.Pow(10, i - 1));
        if (start != end) return false;
    }
    return true;
}

Console.Write("Введите 5ти значное число: ");
int value = Convert.ToInt32(Console.ReadLine());

if (IsNumberPalindrom(value, 5)) // 5 - кол-во цифр в числе
    Console.Write($"Число ({value}) является палиндромом.");
else
    Console.Write($"Число ({value}) не является палиндромом.");
 */
//------------------------------------------------------------------------

/* 
Задача 21.
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
 */
/* 
double GetDistanceFromPoints(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
}

Console.Write("Введите точку aX: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку aY: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку aZ: ");
int aZ = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку bX: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку bY: ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку bZ: ");
int bZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введены координаты: A(x:{aX}; y:{aY}; z:{aZ}) B(x:{bX}; y:{bY}; z:{bZ})...");
Console.WriteLine($"Расстояние между точками A и B: {GetDistanceFromPoints(aX, aY, aZ, bX, bY, bZ)}.");
 */
//------------------------------------------------------------------------
/* 
Задача 23.
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
 */

void OutConsoleNumbersInCube(int arg)
{
    for (int i = 1; i <= arg; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

OutConsoleNumbersInCube(number);