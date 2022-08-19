// работа с массивами

using static System.Console;
Clear();
//string[] arrayString = ReadLine().Split(new char[]{' ','#',','}, StringSplitOptions.RemoveEmptyEntries);
//int[] array= new int[3];

//for(int i=0;i<array.Length;i++)
//{
////    array[i]=int.Parse(ReadLine());
//}
//WriteLine($"[{String.Join(",",array)}]");

// метод для массива

int[] array = GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(",",array)}]");

int[] GetArrayFromString(string arrayString)
{
    string[] massString = arrayString.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    int[] result =new int [massString.Length];
    for(int i=0;i<result.Length;i++)
    {
        result[i] = int.Parse(massString[i]);
    }
    return result;
}