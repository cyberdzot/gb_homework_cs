//--------------------------[ Методы ]---------------------------------
/* 
void PrintNaturalNumbers(int startNumber)
{
    Console.Write(startNumber + " ");
    if (startNumber > 1)
        PrintNaturalNumbers(startNumber - 1);
} */

int GetSumNaturalNumbers(int m, int n)
{
    if (m > n)
        return GetSumNaturalNumbers(m, n + 1) + n;
    else if (m < n)
        return GetSumNaturalNumbers(m + 1, n) + m;

    return m;
}
//--------------------------[ Задачи ]------------------------------------
/* 
Задача 64:
Задайте значение N.
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
 */
/* 
Console.Write("Введите натуральное число: ");
int natural = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(natural);
 */
//------------------------------------------------------------------------
/* 
Задача 66:
Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 */

Console.Write("Введите натуральное число №1: ");
int aNatural = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число №2: ");
int bNatural = Convert.ToInt32(Console.ReadLine());

Console.Write("Сумма натуральных чисел: "
                + GetSumNaturalNumbers(aNatural, bNatural));
//------------------------------------------------------------------------