// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M ");
int number_M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N");
int number_N = Convert.ToInt32(Console.ReadLine());
if (number_M < 0 || number_N < 0)
{
    Console.WriteLine("Вы ввели ненатуральное число");
    return;
}
int sum_Elem = SumDigitRange(number_M, number_N);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum_Elem}");

int SumDigitRange(int m, int n)
{

    if (m == n) return m;

    return m + SumDigitRange(m + 1, n);
}

