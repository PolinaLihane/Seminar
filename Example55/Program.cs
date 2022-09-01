// Задача 55:
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
using static System.Console;
Clear();

WriteLine("Введите размеры массива мин и макс значения через пробел");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);

if (parameters[0] != parameters[1])
{
    WriteLine("не возможно поменять местами");
    return;
}
PrintMatrixArray(matrix);
WriteLine();
PrintMatrixArray(GetSwitch(matrix));

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
int[,] GetSwitch(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

    {
        for (int i = 0; i < matrix.GetLength(0); i++)   //можно через темп. длину i делим на 2
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                newMatrix[j, i] = matrix[i, j];
            }
        }
    }
    return newMatrix;
}