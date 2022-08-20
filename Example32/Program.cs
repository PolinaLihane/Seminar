// тип 32
// Напишите программу замена элементов массива: 
// элементы замените на соответствующие отрицательные, и наоборот.
using static System.Console;
Clear();
int[] array =GetArray(12, -9, 9);
WriteLine($"{String.Join(" ",array)}");
GetSwitch(array);
WriteLine($"{String.Join(" ",array)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i =0; i < size; i++)
    {
        result[i]=new Random().Next(minValue,maxValue+1);
    }
    return result;
}

void GetSwitch(int[] array)
{
    for (int i = 0;i < array.Length; i++)
      array[i] *= -1; 
}