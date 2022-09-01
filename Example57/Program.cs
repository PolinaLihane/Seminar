// Задача 57: 
//Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
//1) ввод массива
//2)создание случайного массива
//3)переводим матрицу в одномерную. развертывание массива
//4) сортируем по возрастанию. 
//5) считаем каждый элемент

using static System.Console;
Clear();
WriteLine("Введите параметры массива: ");
int[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();
int[,] array=GetMatrix(parameters[0],parameters[1],parameters[2],parameters[3]);
PrintMatrix(array);
WriteLine();
int[] rowArray=GetRowArray(array);
SortArray(rowArray);
WriteLine(String.Join(" ",rowArray));
WriteLine();
PrintData(rowArray);

int[,] GetMatrix(int rows, int colums,int minValue,int maxValue)
{
    int[,] result=new int[rows,colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i,j]=new Random().Next(minValue,maxValue);
        }  
    }
    return result;
}

int[] GetRowArray(int[,] inArray) //разворачиваем массив
{
    int[] result=new int[inArray.GetLength(0)*inArray.GetLength(1)];
    int k=0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[k]=inArray[i,j];
            k++;            
        }
    }
    return result;
}

void SortArray(int[] inArray) //пузырьковая сортировка от мин к макс
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i+1; j < inArray.Length; j++) //i+1 берем следующий эл тут
        {
            if (inArray[i]>inArray[j]) //если предыдущий больше,то меняем местами.
            {
                int temp=inArray[i];
                inArray[i]=inArray[j];
                inArray[j]=temp;
            }
        }
    }
}

void PrintMatrix(int[,] inArray) //печать масс
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

void PrintData(int[] inArray)
{
    int el=inArray[0];
    int count=1; //тк уже есть 0 эл
    for (int i = 1; i < inArray.Length; i++)
    {
        if(el!=inArray[i])
        {
            WriteLine($"{el}-->{count};");
            el=inArray[i];
            count=1;
        }
        else
        {
            count++;
        }
    }
    WriteLine($"{el}-->{count};");
}

struct Point
{
    public int x;
    public int y;
    public int z;
}
