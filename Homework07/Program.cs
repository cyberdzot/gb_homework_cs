//--------------------------[ Методы ]---------------------------------

double[,] CreateRandom2dArrayDouble(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
            array[i, j] += new Random().NextDouble();
            array[i, j] = Math.Round(array[i, j], 2);
        }

    return array;
}

void Show2dArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreateRandom2dArrayInt(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return array;
}

void Show2dArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int GetValueFrom2dArray(int[,] array, int row, int column)
{
    return array[row, column];
}

bool IsValueFrom2dArray(int[,] array, int row, int column)
{
    if (row < array.GetLength(0) && column < array.GetLength(1))
        return true;

    return false;
}

//--------------------------[ Задачи ]------------------------------------
/* 
Задача 47.
Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
*/
/* 
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArrayDouble(m, n, min, max);
Show2dArrayDouble(myArray);
 */
//------------------------------------------------------------------------
/* 
Задача 50.
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
 */
Console.Write("Введите строку: ");
int inputRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int inputCol = Convert.ToInt32(Console.ReadLine());

int[,] randArray = CreateRandom2dArrayInt(5, 5, 10, 98);
Show2dArrayInt(randArray);

if (IsValueFrom2dArray(randArray, inputRow, inputCol))
    Console.Write($"В указанной позиции элемент ({GetValueFrom2dArray(randArray, inputRow, inputCol)}).");
else
    Console.Write("В указанной позиции элемент отсутствует!");



