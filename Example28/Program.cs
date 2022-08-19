// 28 
//Принимаем N. выдаем произведение от 1 до N

using static System.Console;
Clear();

WriteLine("Введите N");
int N = int.Parse(ReadLine());
int sum = GetSum(N);
WriteLine(sum);


int GetSum(int N)
{
    int result = 0;
    for(int i=1; i<=N;i++)
    {
     result+=i;
    }
    return result;
}