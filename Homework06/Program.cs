//--------------------------[ Методы ]---------------------------------

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
}


//--------------------------[ Задачи ]------------------------------------
/* 
Задача 41:
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
 */

Console.Write("Введите количество чисел: ");
int numCount = Convert.ToInt32(Console.ReadLine());
int natCount = GetNaturalNumbersCount(numCount);

if (natCount > 0)
    Console.WriteLine($"Найдено натуральных чисел: {natCount}.");
else
    Console.WriteLine("Натуральных чисел не найдено!");
