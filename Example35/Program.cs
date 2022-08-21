// 35
//Случайный массив. сколько элементов лежат в отрезке [10,99]

using static System.Console;
Clear();
WriteLine("Введите размер");
int size = int.Parse(ReadLine());
// int count =0;
int[] array = GetArray(size);
WriteLine($"[{String.Join(",",array)}]");
int min = 10;
int max = 99;
int NewCount = FindNumbers(array,min,max);
WriteLine(NewCount);
//foreach(int item in array)
//{
  //  count+=item<99&&item>10?item:0;
//}
//WriteLine(count);
int FindNumbers(int[] array,int min, int max)
{
    int count = 0;
    for (int i=0; i<array.Length;i++)
    {
        if (array[i] >= min && array[i] <= max) count++;
    }
    return count;
}


int[] GetArray(int size)
{
    int[] result=new int[size];
    for (int i=0;i<size;i++)
    {
        result[i]=new Random().Next(0,150);
    }
    return result;
}