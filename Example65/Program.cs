// Задача 65: 
//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
using static System.Console;
Clear();
int M = int.Parse(ReadLine());
int N = int.Parse(ReadLine());
WriteLine(GetStringNumbers(M, N));
WriteLine(GetStringNumbers1(M, N));
WriteLine(GetStringNumbers2(M, N));

string GetStringNumbers(int m1, int n1)
{
    if (m1 <= n1)
    {
        return (n1 == m1) ? $"{m1}" : $"{GetStringNumbers(m1, n1 - 1)} {n1}";
    }
    else
    {
        return (n1 == m1) ? $"{n1}" : $"{GetStringNumbers(n1, m1 - 1)} {m1}";
    }
}

string GetStringNumbers1(int m1, int n1)
{
    if (n1 == m1) return $"{m1}";
    else if (m1 > n1) return GetStringNumbers1(m1 - 1, n1) + $" {m1}";
    return GetStringNumbers1(n1 - 1, m1) + $" {n1}";
}

string GetStringNumbers2(int m1, int n1)
{
    return (n1 == m1)?$"{n1}":n1<m1?$"{n1} "+GetStringNumbers2(n1+1,m1):$"{m1} "+GetStringNumbers2(m1+1,n1);
}