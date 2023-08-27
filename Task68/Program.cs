// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите натуральное число M ");
int number_M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N");
int number_N = Convert.ToInt32(Console.ReadLine());
if (number_M < 0 || number_N < 0)
{
    Console.WriteLine("Вы ввели ненатуральное число");
    return;
}
int ack = Ack(number_M, number_N);
Console.WriteLine(ack);

int Ack(int m, int n)
{

    if (m == 0) { return n + 1; }

    else if (n == 0)
    {
        return Ack(m - 1, 1);
    }
    else return Ack(m - 1, Ack(m, n - 1));
}