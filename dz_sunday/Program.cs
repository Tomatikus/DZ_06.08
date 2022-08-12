/***Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*
Console.WriteLine("Введите трехзначное число ");
string inputNumber = Console.ReadLine(); 
Console.WriteLine(inputNumber[1]);
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

/*
Console.WriteLine("Введите трехзначное число ");
string inputNumber = Console.ReadLine(); 
int Arraylength = inputNumber.Length;
if (Arraylength < 3 )
{
    Console.WriteLine("третьей цифры нет");
}
Console.WriteLine(inputNumber[2]);
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


Console.WriteLine("Введите цифрой день недели ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number <= 5 ) Console.WriteLine(" -> нет - рабочий");
else Console.WriteLine(" -> да - выходной");
