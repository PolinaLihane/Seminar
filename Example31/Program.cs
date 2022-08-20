//31
// вывести массив указанной длины и вычислить суммы + и - элементов

using static System.Console;
Clear();
int[] array =GetArray(12, -9, 9);// длина 12 от -9 до 9 числа
WriteLine($"{String.Join(" ",array)}");
int positiveSum=0;
int negativeSum=0;
foreach(int item in array) // поиск(опрос) в массиве item нельзя изменять
{
    positiveSum+=item>0?item:0;
 //+= + к прошлому значению.если итем больше 0.итем присвоить 0
    negativeSum+=item<0?item:0;
}
WriteLine($"Сумма положительных = {positiveSum}");
WriteLine($"Сумма отрицательных = {negativeSum}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i =0; i < size; i++)
    {
        result[i]=new Random().Next(minValue,maxValue+1);
    }
    return result;
}
