/*
Задача 2.
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/

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




