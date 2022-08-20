// 35
//Случайный массив. сколько элементов лежат в отрезке [10,99]

using static System.Console;
Clear();
WriteLine("Введите размер");
int size = int.Parse(ReadLine());
int count=0;
int[] array = GetArray(size);
WriteLine($"[{String.Join(",",array)}]");

foreach(int item in array)
{
    count+=item<99&&item>10?item:0;
}
WriteLine(count);

int[] GetArray(int size)
{
    int[] result=new int[size];
    for (int i=0;i<size;i++)
    {
        result[i]=new Random().Next(-999,999);
    }
    return result;
}