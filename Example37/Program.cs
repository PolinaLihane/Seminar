// 37
// Задать массив в указанном диапазоне и выдать поизведение пар чисел
//1 и последний, 2 и предпоследний и тд
//если кол-во не четное то центральный элемент не умножаем сам на себя

using static System.Console;
Clear();
WriteLine("введите длину массива");
int size = int.Parse(ReadLine());
WriteLine("введите начало диапазона");
int minValue = int.Parse(ReadLine());
WriteLine("введите конец диапазона");
int maxValue = int.Parse(ReadLine());
int[] array = GetArray(size, minValue, maxValue);
WriteLine($"[{String.Join(" ", array)}]");
int[] NewArray = GetNewArray(array);
WriteLine($"{String.Join(" ", NewArray)}");

int[] GetNewArray(int[] array)
{
    int newsize = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;
    int[] result = new int[newsize];
    for (int i = 0; i < array.Length/2; i++)
    {
        result[i] = array[i] + array[array.Length - i - 1];
    }
   if (array.Length%2==1)
   {
    result[newsize-1]= array[array.Length/2];
   }
    return result;
}


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}
//int[] GetNewArray(int[] array)
//{
   // int newsize = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;
  //  int[] result = new int[newsize];
  //  for (int i = 0; i < array.Length; i++)
   // {
    //if (array[i]!=array[(array.Length-1)-i])
   //   { result[i] = array[i] + array[(array.Length - 1)- i];}
   // else result[i]=array[i]
  //  }
  // }
//return result;
//}