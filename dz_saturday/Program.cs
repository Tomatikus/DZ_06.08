/***Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.WriteLine("Введите 2 числа: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
int secondDigit = Convert.ToInt32(Console.ReadLine());

int maximum = secondDigit;
int minimum = firstDigit;

if (maximum < minimum) maximum = secondDigit;
if (maximum > minimum) minimum = firstDigit;


Console.WriteLine($"Минимальная цифра - это {minimum}" );
Console.WriteLine($"Максимальная цифра - это {maximum}" );
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/ 

/*
Console.WriteLine("Введите 3 числа: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
int secondDigit = Convert.ToInt32(Console.ReadLine());
int thirdDigit = Convert.ToInt32(Console.ReadLine());

int maximum = firstDigit;
int midle = secondDigit;
int minimum = thirdDigit;

if (maximum < midle) maximum = secondDigit;
if (midle < minimum) maximum = thirdDigit;
if (minimum < maximum) maximum = firstDigit;

Console.WriteLine($"Максимальная цифра - это {maximum}" );
*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

/*
int firstNumber = Convert.ToInt32(Console.ReadLine());   
int secondNumber = Convert.ToInt32(Console.ReadLine());  
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % 2 == 0) 
{
    Console.WriteLine($"{firstNumber } -> да");
}
else Console.WriteLine($"{firstNumber } -> нет");

if (secondNumber % 2 == 0) 
{
    Console.WriteLine($"{secondNumber} -> да");
}
else Console.WriteLine($"{secondNumber} -> нет");

if (thirdNumber % 2 == 0) 
{
    Console.WriteLine($"{thirdNumber } -> да");
}
else Console.WriteLine($"{thirdNumber } -> нет");
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int number = Convert.ToInt32(Console.ReadLine()); 
int negativenumber = number /number +1;         // -n = n* (-1)

while (negativenumber<= number)
{
    Console.Write(negativenumber + " ");
    negativenumber = negativenumber + 2;
}    