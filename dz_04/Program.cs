// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

/*
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumber(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + "," + PrintNumber(start + 1, end));
}
Console.WriteLine($"Числа от 1 до {N}: {PrintNumber(M ,N)}");
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
Console.WriteLine("Введите число 1:");
int D = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int A = Convert.ToInt32(Console.ReadLine());

int PrintNumber(int d, int a, int sum)
{
    sum = a;
    if (d == a) return sum;
    return (sum + PrintNumber(d, a - 1, sum));
}
Console.WriteLine($"Сумма чисел от {D} до {A}: {PrintNumber(D, A, 0)}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью 
//рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите число 1:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int B = Convert.ToInt32(Console.ReadLine());

int Ackerman(int a, int b)
{
    if (a == 0) return b + 1;
    else if (b == 0) return Ackerman(a - 1, 1);
    else return Ackerman(a - 1, Ackerman(a, b - 1));
}
Console.Write($"Функция аккермана от чисел {A} и {B} равна = {Ackerman(A, B)}");