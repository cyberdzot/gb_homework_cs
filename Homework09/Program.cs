//--------------------------[ Методы ]---------------------------------

void PrintNaturalNumbers(int startNumber)
{
    Console.Write(startNumber + " ");
    if (startNumber > 1)
        PrintNaturalNumbers(startNumber - 1);
}

//--------------------------[ Задачи ]------------------------------------
/* 
Задача 64:
Задайте значение N.
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
 */

Console.Write("Введите натуральное число: ");
int natural = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(natural);

//------------------------------------------------------------------------

