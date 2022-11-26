//--------------------------[ Методы ]---------------------------------
/* 
void PrintNaturalNumbers(int startNumber)
{
    Console.Write(startNumber + " ");
    if (startNumber > 1)
        PrintNaturalNumbers(startNumber - 1);
} 

int GetSumNaturalNumbers(int m, int n)
{
    if (m > n)
        return GetSumNaturalNumbers(m, n + 1) + n;
    else if (m < n)
        return GetSumNaturalNumbers(m + 1, n) + m;

    return m;
}
*/
int CalculateAckermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return CalculateAckermann(m - 1, 1);

    return CalculateAckermann(m - 1, CalculateAckermann(m, n - 1));
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
/* 
Console.Write("Введите натуральное число №1: ");
int aNatural = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число №2: ");
int bNatural = Convert.ToInt32(Console.ReadLine());

Console.Write("Сумма натуральных чисел: "
                + GetSumNaturalNumbers(aNatural, bNatural));
 */
//------------------------------------------------------------------------
/* 
Задача 68:
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
 */

Console.Write("Введите первое неотрицательное число: ");
int mNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе неотрицательное число: ");
int nNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({mNumber},{nNumber}) = {CalculateAckermann(mNumber, nNumber)}");