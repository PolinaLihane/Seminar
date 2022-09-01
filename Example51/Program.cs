//51
//Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
using static System.Console;
using System.Linq;
Clear();
Write("Введите размеры массива мин и макс значения через пробел");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);

PrintMatrixArray(matrix);
WriteLine();
WriteLine(GetSum(matrix));
WriteLine(GetSum2(matrix));

int[,] GetMatrixArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

int GetSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrix[i, j];
            }
        }
    }
    return sum;
}

int GetSum2(int[,] matrix)
{
    int sum = 0;
    int size = matrix.GetLength(0) < matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);
    //есть строк больше чем столбцов то будет ошибка без этой строки.
    for (int i = 0; i < size; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

