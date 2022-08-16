// методы
// принимаем число, вывести от 1 до А

using static System.Console;
Clear();

WriteLine("введите число");
int A = int.Parse(ReadLine());
int result=GetSum(A);
WriteLine($"Сумма от 1 до {A} ={result}");



int GetSum(int number)
{
    int sum = 0;
    for(int i=1;i<=number;i++)
    {
        sum+=i;
    }
    return sum;
}