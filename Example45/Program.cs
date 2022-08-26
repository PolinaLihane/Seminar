// Задача 45: 
//Напишите программу, которая будет создавать копию заданного массива с 
//помощью поэлементного копирования
using static System.Console;
Clear();
int[] mas={1,5,4,7};
int[] newmas=CopyMas(mas);
WriteLine($"{String.Join(",",newmas)}");
int[] CopyMas(int[]mas)
{
    int[] masCopy=new int[mas.Length];
    for (int i=0;i<mas.Length;i++)
    {
        masCopy[i]=mas[i];
    }
    return masCopy;
}