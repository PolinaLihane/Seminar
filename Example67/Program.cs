// Задача 67: 
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
using static System.Console;
Clear();
int number = int.Parse(ReadLine());
WriteLine(GetSum(number));

int GetSum(int num)
{
    return (num>0)?num%10+GetSum(num/10):0;
}
