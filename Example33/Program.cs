//тип 33
//  Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

using static System.Console;
Clear();

int[] GetArray=GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(",",GetArray)}]");
WriteLine("Введите число");
int number = int.Parse(ReadLine());
bool res = FindNumber(GetArray,number);
WriteLine(res);
bool FindNumber(int[] GetArray,int number)
{
    for (int i =0;i<GetArray.Length;i++)
    {
        if (GetArray[i] == number)
        {
            return true;
        }
    }
 return false;
}

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
