// Задача 48:
// Задайте двумерный массив размера m на n, каждый элемент в 
//массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив 
//на экран.

using static System.Console;
using System.Linq;
Clear();

WriteLine("Ведите размер двумерного массива m и n");
int[] parameters = ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

int[,] matrix = GetMatrixArray(parameters[0], parameters[1]);

PrintMatrixArray(matrix);

int[,] GetMatrixArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}
// обратный порядок
int[,] ArrayXy(int m,int n)
{
    int[,] inArray=new int[m,n];
    for (int i=0;i<m;i++)
    {
        for (int j=0;j<n;j++)
        {
            inArray[i,j]=(m-1-i)+(n-1-j);
        }
    }
    return inArray;
}