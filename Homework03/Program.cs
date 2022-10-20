/*
Задача 19.
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/

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


//------------------------------------------------------------------------
