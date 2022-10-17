/*
Задача 10.
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/
int GetSecondDigit( int arg )
{
    return (arg / 10 % 10);
}

Console.Write("Введите трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32( Console.ReadLine() );

Console.Write($"Вторая цифра: {GetSecondDigit( threeDigitNumber )}.");

//------------------------------------------------------------------------