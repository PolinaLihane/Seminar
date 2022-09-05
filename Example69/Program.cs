//  69:
//Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.
using static System.Console;
Clear();
WriteLine("Введите первое число");
int a = int.Parse(ReadLine());
WriteLine("Введите второе число");
int b = int.Parse(ReadLine());
WriteLine(GetSum(a,b));

int GetSum(int num1,int num2)
{ 
    return (num2>0)?num1*GetSum(num1,num2-1):1;
}
