//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

using static System.Console;
using System.Linq;
        Clear();
           Write("Введите размеры массива мин и макс значения через пробел");
        int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

        int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);

        PrintMatrixArray(matrix);
        WriteLine();
        int[,] newmatrix = GetSquareArray(matrix);
        PrintMatrixArray(newmatrix);

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

        int[,] GetSquareArray(int[,] matrix)
        {
            for (int i = 2; i < matrix.GetLength(0); i++)
            {
                for (int j = 2; j < matrix.GetLength(1); j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        matrix[i,j]*=matrix[i,j];
                    }
                }
            }
            return matrix;
        }
    
