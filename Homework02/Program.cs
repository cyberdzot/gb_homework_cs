/*
Задача 10.
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/
/*
int GetSecondDigit(int arg)
{
    return (arg / 10 % 10);
}

Console.Write("Введите трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

Console.Write($"Вторая цифра: {GetSecondDigit(threeDigitNumber)}.");
*/
//------------------------------------------------------------------------
/*
Задача 13.
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/
/*
int GetCountDigits(int number)
{
    int i = 0;
    int tempNum = number;
    while (tempNum != 0)
    {
        tempNum = tempNum / 10;
        i++;
    }
    return i;
}

int GetDigitSetPos(int pos, int number)
{
    int factor = 1; // множитель, если число будет длинное
    int count = GetCountDigits(number);
    if (count < pos) return -1;
    else if (count > pos)
    {
        int i = count - pos;
        while (i > 0)
        {
            factor = factor * 10;
            i--;
        }
    }
    return (number / factor % 10);
}

Console.Write("Введите число: ");
int readNumber = Convert.ToInt32(Console.ReadLine());

int digit = GetDigitSetPos(3, readNumber);
if (digit != -1)
    Console.Write($"Третья цифра введённого числа: {digit}.");
else
    Console.Write("У введённого числа отсутствует третья цифра.");
*/
//------------------------------------------------------------------------
/*
Задача 15.
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/

bool IsDayOff(int day)
{
    bool[] dayOff = new bool[7] { false, false, false, false, false, true, true };

    return dayOff[day - 1];
}

Console.Write("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (IsDayOff(number))
    Console.Write($"Введённый день ({number}) является выходным.");
else
    Console.Write($"Введённый день ({number}) является рабочим.");
