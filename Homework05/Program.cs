//--------------------------[ Методы ]---------------------------------
/* 
int[] CreateRandomArrayInt(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArrayInt(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine(" \n");
}

int GetCountEvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;

    return count;
}

int GetSumElementsInOddPos(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];

    return sum;
} */

double[] CreateRandomArrayDouble(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        array[i] += Math.Round(new Random().NextDouble(), 2);
    }

    return array;
}

void ShowArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine(" \n");
}

double GetDiffMaxAndMinDouble(double[] array)
{
    double diff = 0.0;
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    diff = max - min;

    return diff;
}


//--------------------------[ Задачи ]------------------------------------
/* 
Задача 34:
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
*/
/* 
Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] randomArray = CreateRandomArrayInt(size, 100, 1000);
ShowArrayInt(randomArray);

Console.Write($"В сгенерированном массиве {GetCountEvenNumbers(randomArray)} чётных чисел.");
 */
//------------------------------------------------------------------------
/* 
Задача 36:
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
*/
/* 
Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] randomArray = CreateRandomArrayInt(size, -10, 11);
ShowArrayInt(randomArray);

Console.Write($"В сгенерированном массиве сумма элементов, стоящих на нечётных позициях равна {GetSumElementsInOddPos(randomArray)}.");
 */
//------------------------------------------------------------------------
/* 
Задача 38:
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
*/

Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] randomArray = CreateRandomArrayDouble(size, -10, 11);
ShowArrayDouble(randomArray);

Console.Write($"Разница между максимальным и минимальным элементами массива равна {GetDiffMaxAndMinDouble(randomArray)}.");
