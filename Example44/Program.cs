//Задача 44: 
//Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3

using static System.Console;
using System.Linq;
Clear();
//WriteLine("Введите число");
// number = int.Parse(ReadLine());
//int[] array = Febon(number);
//WriteLine($"{String.Join(" ",array)}");

int[] Febon(int number)
{
    int[] array = new int[number];
    array[0]=0;
    array[1]=1;
    for (int i=2;i<number;i++)
    {
        array[i]=array[i-2]+array[i-1];
    }
    return array;
}
// подсчет четных чисел

WriteLine("Введите массив через пробел");
int count=ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray().Where(a=>a%2==0).Count();

WriteLine(count);