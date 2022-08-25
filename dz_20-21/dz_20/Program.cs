// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int [] array = new int [5];
int i = 0;
int count = 0;
while (i < 5)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        count++;
    }
    i++;
}
Console.Write($"Array: [ {String.Join("; ", array)} -> {count} ]");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
Console.Write("Введите количество элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine());

int [] elements = new int [numberElements];
int sum = 0;

for (int i = 0; i < elements.Length; i++)
{
    elements [i] = new Random().Next(19);
    if (i % 2 != 0)
    {
        sum = sum + elements [i];
    }
    
}
Console.Write($"Получившийся массив: [{String.Join(",", elements)}] ");
Console.WriteLine($"{elements}");
Console.Write($"Сумма всех нечетных элементов = {sum}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] arrayNumbers = new double[10];
  for (int i = 0; i < arrayNumbers.Length; i++ )
  {
    arrayNumbers[i] = new Random().Next(1,20);
    Console.Write(arrayNumbers[i] +"," );
  }

double maxNumber = arrayNumbers[0];
double minNumber = arrayNumbers[0];

for (int i = 1; i < arrayNumbers.Length; i++)
{
    if (maxNumber < arrayNumbers[i])
    {
      maxNumber = arrayNumbers[i];
    }
    if (minNumber > arrayNumbers[i])
    {
        minNumber = arrayNumbers[i];
    }
}

double difference = maxNumber - minNumber;
System.Console.WriteLine();
Console.WriteLine($"Разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {difference}");