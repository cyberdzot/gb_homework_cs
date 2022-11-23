//--------------------------[ Методы ]---------------------------------
/* 
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

void SwapInt(ref int arg1, ref int arg2)
{
    int temp = arg1;
    arg1 = arg2;
    arg2 = temp;
}

void Sort2dArrayRows(int[,] array) // пузырьковая
{
    int colsLen = array.GetLength(1);
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < colsLen; j++)
        {
            for (int s = 0; s < colsLen - j - 1; s++)
            {
                if (array[i, s] < array[i, s + 1]) // на убывание
                    SwapInt(ref array[i, s], ref array[i, s + 1]);
            }
        }
}

int GetMinSumElementsRowInArray(int[,] array)
{
    int countRows = array.GetLength(0);
    int[] sumRows = new int[countRows];

    for (int i = 0; i < countRows; i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sumRows[i] += array[i, j];

    int idMin = 0;

    for (int i = 1; i < countRows; i++)
        if (sumRows[i] < sumRows[idMin]) idMin = i;

    return idMin + 1; // нам ведь нужна строка, а не индекс :)
}

void QuadMatrixMultiplication(int a1, int a2, int b1, int b2,
                            int c1, int c2, int d1, int d2)
{
    Console.WriteLine("Результат произведения двух матриц: ");
    Console.WriteLine($"|{a1 * c1 + b1 * c2} {a1 * d1 + b1 * d2}|");
    Console.WriteLine($"|{a2 * c1 + b2 * c2} {a2 * d1 + b2 * d2}|\n");
} */

int[,,] Create3dArrayNoRepeatValue(int rows, int columns, int depth, int minValue, int maxValue)
{
    int[,,] array = new int[rows, columns, depth];
    bool[] valueMemory = new bool[maxValue + 1];

    for (int r = 0; r < rows; r++)
        for (int c = 0; c < columns; c++)
            for (int d = 0; d < columns; d++)
            {
            ReRandom:
                int valueNew = new Random().Next(minValue, maxValue + 1);
                if (valueMemory[valueNew]) goto ReRandom;
                valueMemory[valueNew] = true;
                array[r, c, d] = valueNew;
            }

    return array;
}

void Show3dArrayInt(int[,,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
        for (int c = 0; c < array.GetLength(1); c++)
            for (int d = 0; d < array.GetLength(2); d++)
                Console.Write($"{array[r, c, d]}({r},{c},{d})\n");
}

//--------------------------[ Задачи ]------------------------------------
/* 
Задача 54:
Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
 */
/* 
Console.Write("Введите количество строк: ");
int inputRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int inputCol = Convert.ToInt32(Console.ReadLine());
int min = 10;
int max = 99;

int[,] randArray = CreateRandom2dArrayInt(inputRow, inputCol, min, max);
Show2dArrayInt(randArray);
Sort2dArrayRows(randArray);
Show2dArrayInt(randArray);
 */
//------------------------------------------------------------------------
/* 
Задача 56:
Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
 */
/* 
Console.Write("Введите количество строк: ");
int inputRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int inputCol = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 9;

int[,] randArray = CreateRandom2dArrayInt(inputRow, inputCol, min, max);
Show2dArrayInt(randArray);

Console.Write("Номер строки с наименьшей суммой элементов: "
                + GetMinSumElementsRowInArray(randArray));
 */
//------------------------------------------------------------------------
/* 
Задача 58:
Задайте две матрицы.
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
 */
/* 
Console.WriteLine("Пусть матрицы выглядят так: \n");
Console.WriteLine("|a1 b1| |c1 d1|");
Console.WriteLine("|a2 b2| |c2 d2|\n");

Console.Write("Введите a1: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите a2: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите c1: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c2: ");
int c2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите d1: ");
int d1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите d2: ");
int d2 = Convert.ToInt32(Console.ReadLine());

QuadMatrixMultiplication(a1, a2, b1, b2, c1, c2, d1, d2);
 */
//------------------------------------------------------------------------
/* 
Задача 60.
...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
 */

Console.Write("Введите кол-во строк: ");
int inputRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int inputCol = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину: ");
int inputDep = Convert.ToInt32(Console.ReadLine());
int min = 10;
int max = 99;

int[,,] randArray = Create3dArrayNoRepeatValue(inputRow, inputCol, inputDep, min, max);
Show3dArrayInt(randArray);

//------------------------------------------------------------------------

