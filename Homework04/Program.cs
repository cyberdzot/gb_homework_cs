/*
Задача 25:
Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
*/

int CustomMathPow(int a, int b)
{
    int count = 0;
    int sum = 1;

    while (count < b)
    {
        sum *= a;
        count++;
    }

    return sum;
}

Console.Write("Введите число которое нужно возвести: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число для степени: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write($"При возведении числа {numA} в степень {numB} получаем число {CustomMathPow(numA, numB)}.");

//------------------------------------------------------------------------

