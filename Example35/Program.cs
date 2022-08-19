//тип 33
//  Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

using static System.Console;
Clear();

int[] GetArray=GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(",",GetArray)}]");
WriteLine("Введите число");
int number = int.Parse(ReadLine());
bool res = false;
foreach(bool item in GetArray) // поиск(опрос) в массиве item нельзя изменять
{
    res=item=number?item:false;
}
WriteLine(res);
int[] GetArrayFromString(string arrayString)
{
    string[] massString=arrayString.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    int[] result= new int[massString.Length];
    for (int i =0;i<result.Length;i++)
    {
        result[i]=int.Parse(massString[i]);
    }
    return result;
}
