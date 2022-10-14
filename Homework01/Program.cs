/*
Задача 2.
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/
/*
Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32( Console.ReadLine() );
Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32( Console.ReadLine() );

if( number1 > number2 )
    Console.Write($"The number {number1} is greater, the number {number2} is less.");
else if( number1 < number2 )
    Console.Write($"The number {number2} is greater, the number {number1} is less.");
else
    Console.Write("Numbers " + number1 + " and " + number2 + " are equal.");
*/

//------------------------------------------------------------------------
/*
Задача 4.
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/
/*
Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32( Console.ReadLine() );
Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32( Console.ReadLine() );
Console.Write("Enter the third number: ");
int number3 = Convert.ToInt32( Console.ReadLine() );

int max = number1;
if( number2 > max  ) max = number2;
if( number3 > max  ) max = number3;

Console.Write($"The number {max} is the maximum.");
*/

//------------------------------------------------------------------------
/*
Задача 6.
Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
*/

Console.Write("Enter the number: ");
int number = Convert.ToInt32( Console.ReadLine() );

if( number % 2 == 0 )
    Console.Write($"The number {number} is even.");
else
    Console.Write($"The number {number} is odd.");


