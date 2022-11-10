/*
Задача 25:
Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
*/
/* 
int CustomMathPow(int a, int b)
{
    int sum = 1;

    for (int i = 0; i < b; i++) sum *= a;

    return sum;
}

Console.Write("Введите число которое нужно возвести: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число для степени: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write($"При возведении числа {numA} в степень {numB} получаем число {CustomMathPow(numA, numB)}.");
 */
//------------------------------------------------------------------------
/*
Задача 27:
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int SumNumbers(int number)
{
    string strNumber = Convert.ToString(number);
    int cell = 0;
    if (strNumber[0] == '-') cell = 1;

    int len = strNumber.Length;
    if (len < 2 || len < 3 && cell == 1) return -1;

    int sum = 0;
    while (cell < len)
    {
        sum += Convert.ToInt32(strNumber[cell] + "");
        cell++;
    }

    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма цифр в числе {number} равна {SumNumbers(number)}.");

//------------------------------------------------------------------------