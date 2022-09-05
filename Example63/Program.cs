// Задача 63: 
//Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от 1 до N.
using static System.Console;
Clear();
int num=int.Parse(ReadLine());
WriteLine($"{GetStringNumbers(num)}");
WriteLine($"{GetStringNumbers1(num)}");
string GetStringNumbers(int N)
{
 
    if(N==1) return "1"; //когда закончим /пока Н не станет равным 1 будет работать метод
    return GetStringNumbers(N-1)+$" {N}"; //вызываем метод Н-1 и записываем в конец строки. с конца до начала идет присвоение.а вывод с начала будет

}
string GetStringNumbers1(int N)
{
return (N==1)?"1":GetStringNumbers1(N-1)+$" {N}"; //тернарник 
}