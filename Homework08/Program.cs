//--------------------------[ Методы ]---------------------------------
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
/* 
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
 */
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
int max = 98;

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

//------------------------------------------------------------------------

