/* 
Задача 34:
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
 */

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine(" \n");
}
/* 
int GetCountEvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;

    return count;
}

Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] randomArray = CreateRandomArray(size, 100, 1000);
ShowArray(randomArray);

Console.Write($"В сгенерированном массиве {GetCountEvenNumbers(randomArray)} чётных чисел.");
 */
//------------------------------------------------------------------------
/* 
Задача 36:
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
 */

int GetSumElementsInOddPos(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];

    return sum;
}

Console.Write("Укажите размер массива: ");
int _size = Convert.ToInt32(Console.ReadLine());
int[] _randomArray = CreateRandomArray(_size, -10, 11);
ShowArray(_randomArray);

Console.Write($"В сгенерированном массиве сумма элементов, стоящих на нечётных позициях равна {GetSumElementsInOddPos(_randomArray)}.");

//------------------------------------------------------------------------





