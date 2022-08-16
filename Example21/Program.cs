// Принимает число N, выдает таблицу квадратов чисел от 1 до N
using static System.Console;
Clear();

WriteLine("Введите число N");
int N = int.Parse(ReadLine());

int i=1;
while (i<=N)
{
    WriteLine($"{i} * {i} = {i*i}");
    i++;
}