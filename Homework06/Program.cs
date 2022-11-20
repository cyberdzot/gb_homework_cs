//--------------------------[ Методы ]---------------------------------
/* 
int GetNaturalNumbersCount(int numbersCount)
{
    int naturCount = 0;
    for (int i = 0; i < numbersCount; i++)
    {
        Console.Write($"Введите число № {i + 1}: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) naturCount++;
    }
    return naturCount;
} */


string GetPointOfIntersection(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
            return $"Прямые 'y = {k1}x + {b1}' и 'y = {k2}x + {b2}' совпадают!";

        return $"Прямые 'y = {k1}x + {b1}' и 'y = {k2}x + {b2}' параллельны!";
    }
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return $"Прямые 'y = {k1}x + {b1}' и 'y = {k2}x + {b2}' пересекаются в точке ({x}; {y})";
}
//--------------------------[ Задачи ]------------------------------------
/* 
Задача 41:
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
 */
/* 
Console.Write("Введите количество чисел: ");
int numCount = Convert.ToInt32(Console.ReadLine());
int natCount = GetNaturalNumbersCount(numCount);

if (natCount > 0)
    Console.WriteLine($"Найдено натуральных чисел: {natCount}.");
else
    Console.WriteLine("Натуральных чисел не найдено!");
 */
//------------------------------------------------------------------------
/* 
Задача 43:
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
 */

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(GetPointOfIntersection(k1, b1, k2, b2));
