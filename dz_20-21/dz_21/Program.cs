// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
Console.Write("Введи число М (количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int overnull(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) 
    count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {overnull(array)} ");
*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите координаты b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты k2:");
int k2 = Convert.ToInt32(Console.ReadLine());

int c = b2 - b1;
int d = k1 - k2;
int x =  c / d;

int y = k2 *x + b1;
Console.WriteLine($"Точка пересечения {y}");
